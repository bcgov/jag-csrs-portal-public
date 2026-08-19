using Csrs.Api.Models;
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
        public AppConfig GetAppSettings()
        {
            var isMaintenanceBannerVisible = _configuration.GetValue<bool>("ISMAINTENANCEBANNER", defaultValue: false);

            return new AppConfig
            {
                IsLoginDisabled = _configuration.GetValue<bool>("ISLOGINDISABLED", defaultValue: false),
                IsMaintenanceBannerVisible = isMaintenanceBannerVisible,
                MaintenanceBannerText = isMaintenanceBannerVisible
                    ? _configuration.GetValue<string>("MAINTENANCEBANNERTEXT", string.Empty)
                    : string.Empty
            };
        }
    }
}
