using Csrs.Services.FileManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Csrs.Api.Controllers
{
    /// <summary>
    /// Handles inbound requests from Dynamics (service-to-service).
    /// Secured by a separate symmetric-key JWT scheme independent of the OIDC scheme
    /// used by the CSRS portal controllers.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Policy = Microsoft.Extensions.DependencyInjection.AuthenticationExtensions.DynamicsPolicy)]
    public class SharepointController : ControllerBase
    {
        private readonly FileManager.FileManagerClient _fileManagerClient;
        private readonly ILogger<SharepointController> _logger;

        public SharepointController(
            FileManager.FileManagerClient fileManagerClient,
            ILogger<SharepointController> logger)
        {
            _fileManagerClient = fileManagerClient ?? throw new ArgumentNullException(nameof(fileManagerClient));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Creates a folder in SharePoint Online via the FileManager gRPC service.
        /// Called by Dynamics to ensure the corresponding SharePoint folder exists.
        /// </summary>
        /// <param name="request">Document library name and folder name for the folder to create.</param>
        /// <param name="cancellationToken"></param>
        /// <returns>204 No Content on success.</returns>
        /// <response code="204">Folder was created or already exists.</response>
        /// <response code="400">DocumentLibrary or FolderName is missing or empty.</response>
        /// <response code="401">The request does not carry a valid Dynamics JWT.</response>
        /// <response code="500">The FileManager service reported a failure creating the folder.</response>
        [HttpPost("CreateFolder")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CreateFolderAsync(
            [FromBody] CreateFolderInput request,
            CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _logger.LogInformation(
                "Dynamics requested SharePoint folder creation: documentLibrary={DocumentLibrary}, folder={FolderName}",
                request.DocumentLibrary,
                request.FolderName);

            var grpcRequest = new CreateFolderRequest
            {
                DocumentLibrary = request.DocumentLibrary,
                FolderName = request.FolderName
            };

            CreateFolderReply reply;
            try
            {
                reply = await _fileManagerClient.CreateFolderAsync(grpcRequest, cancellationToken: cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "FileManager gRPC call failed while creating folder {FolderName} in library {DocumentLibrary}",
                    request.FolderName, request.DocumentLibrary);
                return StatusCode((int)HttpStatusCode.InternalServerError, "An error occurred while communicating with the file manager service.");
            }

            if (reply.ResultStatus == ResultStatus.Success)
            {
                return NoContent();
            }

            _logger.LogError("FileManager returned failure for folder {FolderName}: {ErrorDetail}",
                request.FolderName, reply.ErrorDetail);
            return StatusCode((int)HttpStatusCode.InternalServerError, reply.ErrorDetail);
        }

        /// <summary>Request body for the CreateFolder endpoint.</summary>
        public sealed class CreateFolderInput
        {
            /// <summary>The SharePoint document library name (e.g. "CSRS File").</summary>
            [Required]
            public string DocumentLibrary { get; set; } = string.Empty;

            /// <summary>The folder name to create inside the document library.</summary>
            [Required]
            public string FolderName { get; set; } = string.Empty;
        }
    }
}
