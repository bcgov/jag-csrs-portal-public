using Csrs.Api.Services;
using Csrs.Interfaces.Dynamics;
using Csrs.Interfaces.Dynamics.Models;
using MediatR;
using Microsoft.Rest;
using System.Net;

namespace Csrs.Api.Features.UserRequests
{
    public static class Create
    {
        public class Request : IRequest<Response>
        {
            public Request(string fileId, string fileNo, string requestType, string requestMessage)
            {
                FileId = fileId;
                FileNo = fileNo;
                RequestType = requestType;
                RequestMessage = requestMessage;
            }
            public string FileId { get; init; }
            public string FileNo { get; init; }
            public string RequestType { get; init; }
            public string RequestMessage { get; init; }
        }
        public class Response
        {
            public Response(string responseMessage)
            {
                ResponseMessage = responseMessage;
            }

            public string ResponseMessage { get; init; }
        }
        public class Handler : IRequestHandler<Request, Response>
        {
            private readonly IDynamicsClient _dynamicsClient;
            private readonly IUserService _userService;
            private readonly IAccountService _accountService;
            private readonly IFileService _fileService;
            private readonly ILogger<Handler> _logger;
            private readonly ITaskService _taskService;

            public Handler(
                IDynamicsClient dynamicsClient,
                IUserService userService,
                IAccountService accountService,
                IFileService fileService,
                ILogger<Handler> logger,
                ITaskService taskService )
            {
                _dynamicsClient = dynamicsClient ?? throw new ArgumentNullException(nameof(dynamicsClient));
                _userService = userService ?? throw new ArgumentNullException(nameof(userService));
                _accountService = accountService ?? throw new ArgumentNullException(nameof(accountService));
                _fileService = fileService ?? throw new ArgumentNullException(nameof(fileService));
                _logger = logger ?? throw new ArgumentNullException(nameof(logger));
                _taskService = taskService ?? throw new ArgumentNullException(nameof(taskService));
            }

            public async Task<Response> Handle(Request request, CancellationToken cancellationToken)
            {
                if (_logger.IsEnabled(LogLevel.Debug))
                {
                    _logger.LogDebug(
                        "➡️ Message Create.Handler START - Processing User Request: FileId={FileId}, FileNo={FileNo}, Type={Type}",
                        request.FileId,
                        request.FileNo,
                        request.RequestType
                    );
                }
                _logger.LogInformation("Creating User Request");

                string userId = _userService.GetBCeIDUserId();
                if (string.IsNullOrEmpty(userId))
                {
                    _logger.LogInformation("No BCeID on authenticated user, cannot create User Request");
                    return new Response("Unauthenticated");
                }
                
                _logger.AddBCeIdGuid(userId);
                MicrosoftDynamicsCRMssgCsrspartyCollection parties = await _dynamicsClient.GetPartyByBCeIdAsync(userId, cancellationToken);

                MicrosoftDynamicsCRMssgCsrsparty? party = parties?.Value?.FirstOrDefault();
                if (party == null)
                {
                    _logger.LogInformation("No associated party found for BCEID {BCeID}", userId);
                    return new Response("No Party Associated");
                }

                _logger.AddPartyId(party.SsgCsrspartyid);
                string desc = $"Party: {party.SsgFullname}\nMessage: {request.RequestMessage}";
                var task = new MicrosoftDynamicsCRMtask
                {
                    FamsOrigin = 451190000,     // Dynamics Label: Portal
                    Activitytypecode = "task",
                    Subject = $"File {request.FileNo} - {request.RequestType}",
                    Description = desc,
                    Isregularactivity = true,
                    Prioritycode = 1,   // Normal
                    Statuscode = 2,     // Not Started
                    Scheduledend = DateTimeOffset.UtcNow
                };             
                //Get the file
                _logger.AddFileId(request.FileId);
                MicrosoftDynamicsCRMssgCsrsfile originFile;
                try
                {
                    originFile = await _dynamicsClient.GetFileByFileId(request.FileId, cancellationToken);
                }
                catch (HttpOperationException ex) when (ex.Response?.StatusCode == HttpStatusCode.NotFound)
                {
                    _logger.LogError(ex, $"ERROR in fetching file {request.FileId}");
                    return new Response("Incorrect file number supplied");
                }

                if (originFile == null)
                {
                    _logger.LogWarning("File {FileId} returned null unexpectedly", request.FileId);
                    return new Response("File not found");
                }

                if (!string.IsNullOrEmpty(originFile._owninguserValue))
                {
                    string userUri = _dynamicsClient.GetEntityURI("systemusers", originFile._owninguserValue);
                    task.OwninguserODataBind = userUri;
                    task.OwnerIdODataBind = userUri;
                }
                else
                {
                    _logger.LogInformation("File {FileId} has no owner, cannot create User Request", request.FileId);
                    return new Response("File has no owner");
                }

                task.RegardingobjectidSsgCsrsfileODataBind = _dynamicsClient.GetEntityURI("ssg_csrsfiles", originFile.SsgCsrsfileid);

                //ap.Statecode = 0;  defaults in DB
                MicrosoftDynamicsCRMtask result = await _dynamicsClient.Tasks.CreateAsync(task);
                _logger.AddProperty("ActivityId", result.Activityid);
                _logger.LogDebug("User Request created successfully: ActivityId={ActivityId}", result.Activityid);
                if (_logger.IsEnabled(LogLevel.Debug))
                {
                    _logger.LogDebug(
                        "🏁 Message Create.Handler END Processing User Request: FileId={FileId}, FileNo={FileNo}, Type={Type}",
                        request.FileId,
                        request.FileNo,
                        request.RequestType
                    );
                }
                
                return new Response("User Request Created");
            }
        }
    }
}