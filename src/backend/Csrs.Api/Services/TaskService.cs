using Csrs.Interfaces.Dynamics;
using Csrs.Interfaces.Dynamics.Models;
using Microsoft.Rest;
using System.Net;

namespace Csrs.Api.Services
{
    public class TaskService : ITaskService
    {

        private readonly IDynamicsClient _dynamicsClient;
        private readonly ILogger<TaskService> _logger;

        public TaskService(
            IDynamicsClient dynamicsClient,
            ILogger<TaskService> logger)
        {
            _dynamicsClient = dynamicsClient ?? throw new ArgumentNullException(nameof(dynamicsClient));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<bool> CreateTask(string fileId, string partyId, string subject, string description, CancellationToken cancellationToken)
        {

            MicrosoftDynamicsCRMtask task = new MicrosoftDynamicsCRMtask();
            task.Subject = subject;
            task.Description = description;
            task.FamsOrigin = 451190000;     // Dynamics Label: Portal

            try
            {

                var select = new List<string> { "ssg_csrsfileid", "_owningteam_value", "_owninguser_value", "_ssg_payor_value", "_ssg_recipient_value" };

                MicrosoftDynamicsCRMssgCsrsfile file = await _dynamicsClient.Ssgcsrsfiles.GetByKeyAsync(fileId, select: select, null, cancellationToken);

                if (file._owninguserValue is not null)
                {
                    task.OwninguserODataBind = _dynamicsClient.GetEntityURI("systemusers", file._owninguserValue);
                    task.OwnerIdODataBind = _dynamicsClient.GetEntityURI("systemusers", file._owninguserValue);
                }


                task.RegardingobjectidSsgCsrsfileODataBind = _dynamicsClient.GetEntityURI("ssg_csrsfiles", file.SsgCsrsfileid);

                // Set FamsSentby based on whether the party is Payor or Recipient
                if (!string.IsNullOrEmpty(partyId))
                {
                    if (partyId == file._ssgPayorValue)
                    {
                        task.FamsSentby = (int)FamsSentBy.Payor;
                    }
                    else if (partyId == file._ssgRecipientValue)
                    {
                        task.FamsSentby = (int)FamsSentBy.Recipient;
                    }
                    else
                    {
                        _logger.LogWarning("Party {PartyId} is neither Payor nor Recipient on file {FileId}", partyId, fileId);
                    }
                }

            }
            catch (HttpOperationException exception) when (exception.Response?.StatusCode == HttpStatusCode.NotFound)
            {

                _logger.LogError("Provided fileId not found");
                return false;

            }

            task.Prioritycode = 1;
            task.Statuscode = 2;
            task.Isregularactivity = true;
            task.Activitytypecode = "task";
            //Set due date. If there is an issue set the timestamp to now?
            task.Scheduledend = DateTimeOffset.UtcNow;

            await _dynamicsClient.Tasks.CreateAsync(task);

            return true;
        }
    }
}
