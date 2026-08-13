using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Csrs.Api.Controllers
{
    public class ConfigController : CsrsControllerBase<ConfigController>
    {
        private readonly IConfiguration _configuration;

        public ConfigController(IMediator mediator, ILogger<ConfigController> logger, IConfiguration configuration)
            : base(mediator, logger)
        {
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpGet("AppConfig")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public List<string> GetAppSettings()
        {
            var activeFeatures = new List<string>();

            var value = _configuration["ISLOGINDISABLED"];
            if (!string.IsNullOrEmpty(value))
            {
                activeFeatures.Add(value);
            }

            return activeFeatures;
        }
    }
}
