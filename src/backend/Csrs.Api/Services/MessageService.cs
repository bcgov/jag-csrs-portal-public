using Csrs.Api.Models;
using Csrs.Api.Repositories;
using Csrs.Interfaces.Dynamics;
using Csrs.Interfaces.Dynamics.Models;
using Microsoft.Rest;
using Microsoft.Extensions.Caching.Memory;
using Csrs.Services.FileManager;

namespace Csrs.Api.Services
{
    public class MessageService : IMessageService
    {

        private readonly IDynamicsClient _dynamicsClient;
        private readonly IDocumentService _documentService;
        private readonly ILogger<MessageService> _logger;

        public MessageService(
            IDynamicsClient dynamicsClient,
            IDocumentService documentService,
            ILogger<MessageService> logger)
        {
            _dynamicsClient = dynamicsClient ?? throw new ArgumentNullException(nameof(dynamicsClient));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _documentService = documentService ?? throw new ArgumentNullException(nameof(documentService));
        }
        public async Task<IList<Message>> GetPartyMessages(string partyId, bool isSent, CancellationToken cancellationToken)
        {
            _logger.LogDebug("IsSent={IsSent}, Get party messages request received for PartyId={PartyId}", isSent, partyId);

            try
            {
                MicrosoftDynamicsCRMssgCsrsfileCollection files = await _dynamicsClient.GetFilesByParty(partyId, isSent, cancellationToken);

                if (files == null || files.Value == null)
                {
                    _logger.LogWarning("IsSent={IsSent}, No files returned for PartyId={PartyId}", isSent, partyId);
                    return new List<Message>();
                }

                if (_logger.IsEnabled(LogLevel.Debug))
                {
                    _logger.LogDebug("IsSent={IsSent}, Retrieved {FileCount} files for PartyId={PartyId}", isSent, files?.Value?.Count ?? 0, partyId);
                }

                List<Message> messages = new List<Message>();
                foreach (var file in files.Value)
                {
                    if (file == null)
                    {
                        _logger.LogWarning("IsSent={IsSent}, Encountered null file object for PartyId={PartyId}", isSent, partyId);
                        continue;
                    }

                    _logger.LogDebug("IsSent={IsSent}, Processing FileId={FileId}", isSent, file.SsgCsrsfileid);

                    int? sentByValue = null;
                    if (isSent)
                    {
                        if (file._ssgPayorValue == partyId)
                            sentByValue = (int)FamsSentBy.Payor;
                        else if (file._ssgRecipientValue == partyId)
                            sentByValue = (int)FamsSentBy.Recipient;
                    }

                    MicrosoftDynamicsCRMssgCsrscommunicationmessageCollection dynamicsMessages = await _dynamicsClient.GetCommunicationMessagesByFile(file.SsgCsrsfileid, partyId, isSent, cancellationToken, _logger, sentByValue);

                    if (dynamicsMessages == null || dynamicsMessages.Value == null)
                    {
                        _logger.LogWarning("IsSent={IsSent}, No communication messages found for FileId={FileId}, PartyId={PartyId}", isSent, file.SsgCsrsfileid, partyId);
                        continue;
                    }

                    if (_logger.IsEnabled(LogLevel.Debug))
                    {
                        _logger.LogDebug("IsSent={IsSent}, Retrieved {MessageCount} messages for FileId={FileId}", isSent, dynamicsMessages?.Value?.Count ?? 0, file.SsgCsrsfileid);
                    }

                    foreach (var message in dynamicsMessages.Value)
                    {

                        if (message == null)
                        {
                            _logger.LogWarning("IsSent={IsSent}, Encountered null message for FileId={FileId}, PartyId={PartyId}", isSent, file.SsgCsrsfileid, partyId);
                            continue;
                        }

                        _logger.LogDebug("IsSent={IsSent}, Processing MessageId={MessageId}, Subject={Subject}", isSent,
                            message.SsgCsrscommunicationmessageid,
                            message.SsgCsrsmessagesubject);

                        IList<FileSystemItem> attachments = new List<FileSystemItem>();

                        //message.SsgCsrsmessageattachment is not Set in Dynamics

                        //Get documents from fileManager
                        try
                        {
                            _logger.LogDebug(
                                "IsSent={IsSent}, Fetching attachments for MessageId={MessageId}, Entity=ssg_csrscommunicationmessage, Subject={Subject}",
                                isSent,
                                message.SsgCsrscommunicationmessageid,
                                message.SsgCsrsmessagesubject
                            );

                            // Check if this is a Task-based message (uploaded document).
                            // Tasks have FamsOrigin = 451190000 (Portal), a linked file, and a
                            // "Document Location:" line in the message body.
                            // Extract document type and filename from description 
                            // Format: "Party: ...\nDocument Type: Court_Application\nDocument Location: entityName\folderName\fileName"
                            string documentType = message.SsgCsrsmessagesubject; // default to subject
                            string? specificFileName = null;
                            bool isDocumentUploadTask = false;

                            if (message.FamsOrigin == 451190000
                                && !string.IsNullOrEmpty(message._ssgCsrsfileValue)
                                && !string.IsNullOrEmpty(message.SsgCsrsmessage))
                            {
                                var lines = message.SsgCsrsmessage.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                                foreach (var line in lines)
                                {
                                    if (line.StartsWith("Document Type:", StringComparison.OrdinalIgnoreCase))
                                    {
                                        documentType = line.Substring("Document Type:".Length).Trim();
                                        _logger.LogDebug("IsSent={IsSent}, Extracted document type: {DocumentType}", isSent, documentType);
                                    }
                                    else if (line.StartsWith("Document Location:", StringComparison.OrdinalIgnoreCase))
                                    {
                                        // Extract filename from path (after last backslash)
                                        string documentLocation = line.Substring("Document Location:".Length).Trim();
                                        int lastBackslash = documentLocation.LastIndexOf('\\');
                                        if (lastBackslash >= 0 && lastBackslash < documentLocation.Length - 1)
                                        {
                                            specificFileName = documentLocation.Substring(lastBackslash + 1);

                                            // Strip document type prefix if present (format: DocumentType__filename)
                                            // This matches the processing in DocumentService.GetListFilesInFolder
                                            if (specificFileName.IndexOf("__") != -1)
                                            {
                                                specificFileName = specificFileName.Substring(specificFileName.IndexOf("__") + 2);
                                            }

                                            _logger.LogDebug("IsSent={IsSent}, Extracted specific filename: {FileName}", isSent, specificFileName);
                                            isDocumentUploadTask = true;
                                        }
                                    }
                                }
                            }

                            if (isDocumentUploadTask)
                            {
                                // For Task-based messages, fetch the specific uploaded file from the File entity
                                attachments = await _documentService.GetAttachmentList(message._ssgCsrsfileValue, "ssg_csrsfile", documentType, cancellationToken);

                                // Filter to only the specific file that was uploaded for this task.
                                // SharePoint may have truncated the filename (stem prefix + original extension),
                                // so we first try an exact match and fall back to a stem-prefix match.
                                if (attachments != null && attachments.Count > 0)
                                {
                                    var exactMatch = attachments
                                        .Where(a => a.Name != null && a.Name.Equals(specificFileName, StringComparison.OrdinalIgnoreCase))
                                        .ToList();

                                    if (exactMatch.Count > 0)
                                    {
                                        attachments = exactMatch;
                                        _logger.LogDebug("IsSent={IsSent}, Exact match for file: {FileName}, Count: {Count}", isSent, specificFileName, attachments.Count);
                                    }
                                    else
                                    {
                                        // SharePoint truncates by cutting the stem; the stored name's stem is always
                                        // a prefix of the full (un-truncated) stem. Match on same extension + stem prefix.
                                        string specificExt = Path.GetExtension(specificFileName);
                                        string specificStem = Path.GetFileNameWithoutExtension(specificFileName);

                                        var prefixMatch = attachments
                                            .Where(a =>
                                            {
                                                if (a.Name == null) return false;
                                                string aExt = Path.GetExtension(a.Name);
                                                string aStem = Path.GetFileNameWithoutExtension(a.Name);
                                                return string.Equals(aExt, specificExt, StringComparison.OrdinalIgnoreCase)
                                                    && specificStem.StartsWith(aStem, StringComparison.OrdinalIgnoreCase);
                                            })
                                            .ToList();

                                        attachments = prefixMatch;
                                        _logger.LogDebug("IsSent={IsSent}, Prefix match for file: {FileName}, Count: {Count}", isSent, specificFileName, attachments.Count);
                                    }
                                }
                            }
                            else
                            {
                                // For regular communication messages
                                attachments = await _documentService.GetAttachmentList(message.SsgCsrscommunicationmessageid, "ssg_csrscommunicationmessage", message.SsgCsrsmessagesubject, cancellationToken);
                            }

                            if (attachments == null || attachments.Count == 0)
                            {
                                _logger.LogDebug(
                                    "IsSent={IsSent}, No attachments found for MessageId={MessageId}, Subject={Subject}",
                                    isSent,
                                    message.SsgCsrscommunicationmessageid,
                                    message.SsgCsrsmessagesubject
                                );
                                attachments = Array.Empty<FileSystemItem>();
                            }
                            else
                            {
                                _logger.LogDebug(
                                    "IsSent={IsSent}, Retrieved {AttachmentCount} attachments for MessageId={MessageId}, Subject={Subject}",
                                    isSent,
                                    attachments.Count,
                                    message.SsgCsrscommunicationmessageid,
                                    message.SsgCsrsmessagesubject
                                );

                                if (_logger.IsEnabled(LogLevel.Debug))
                                {
                                    foreach (var attachment in attachments)
                                    {
                                        _logger.LogDebug(
                                            "IsSent={IsSent}, Attachment for MessageId={MessageId}:\nId={AttachmentId},\nName={AttachmentName},\nSize={AttachmentSize}",
                                            isSent,
                                            message.SsgCsrscommunicationmessageid,
                                            attachment.Id,
                                            attachment.Name,
                                            attachment.Size
                                        );
                                    }
                                }
                            }
                        }
                        catch (HttpOperationException ex)
                        {
                            _logger.LogDebug(
                                ex,
                                "IsSent={IsSent}, No Attachment Retrieved for MessageId={MessageId}, Subject={Subject}: {Message}",
                                isSent,
                                message.SsgCsrscommunicationmessageid,
                                message.SsgCsrsmessagesubject,
                                ex.Message
                            );
                            attachments = Array.Empty<FileSystemItem>();
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError(
                                ex,
                                "IsSent={IsSent}, ERROR OCCURRED getting attachment list for MessageId={MessageId}, Subject={Subject}: {Message}",
                                isSent,
                                message.SsgCsrscommunicationmessageid,
                                message.SsgCsrsmessagesubject,
                                ex.Message
                            );
                            attachments = Array.Empty<FileSystemItem>();
                        }

                        //Temporary add empty array of documents
                        messages.Add(ModelExtensions.ToViewModel(message, attachments));
                    }
                }

                _logger.LogDebug("IsSent={IsSent}, Returning {MessageCount} messages for PartyId={PartyId}", isSent, messages.Count, partyId);

                return messages;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "IsSent={IsSent}, Unhandled exception in GetPartyMessages for PartyId={PartyId}", isSent, partyId);

                throw; // rethrow exception stack
            }
        }

        public async Task SetMessageRead(string messageGuid, CancellationToken cancellationToken)
        {
            _logger.LogDebug("Set party message read request recieved");

            var select = new List<string>() { "ssg_csrsmessageread" };

            var communicationMessage = await _dynamicsClient.Ssgcsrscommunicationmessages.GetByKeyAsync(messageGuid, select, null, cancellationToken);
            if (communicationMessage is null)
            {
                _logger.LogInformation("No associated message Guid, cannot set message to read");
                throw new HttpOperationException("Incorrect message Guid");
            }

            if (communicationMessage.SsgCsrsmessageread == false)
            {
                communicationMessage.SsgCsrsmessageread = true;

                await _dynamicsClient.Ssgcsrscommunicationmessages.UpdateAsync(messageGuid, communicationMessage, cancellationToken);
            }

        }

    }
}
