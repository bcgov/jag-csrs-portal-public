﻿using Csrs.Api.Features.PortalAccounts;
using Csrs.Api.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Csrs.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PortalAccountController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<PortalAccountController> _logger;

        public PortalAccountController(IMediator mediator, ILogger<PortalAccountController> logger)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet("Profile")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IList<PortalAccount>> GetProfileAsync([Required][FromQuery(Name = "bceIDGuid")] Guid bceIDGuid)
        {
            Profile.Request request = new() {  BCeIDGuid = bceIDGuid };
            Profile.Response? response = await _mediator.Send(request);
            return response.Accounts;
        }

        [HttpPost("Signup")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<string> SignupAsync([Required] PortalAccount account)
        {
            Signup.Request request = new(account);
            Signup.Response? response = await _mediator.Send(request);
            return response.Id;
        }

        [HttpPatch("UpdateProfile")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<string> UpdateProfileAsync([Required]PortalAccount account)
        {
            UpdateProfile.Request request = new UpdateProfile.Request(account);
            UpdateProfile.Response? response = await _mediator.Send(request);
            return response.Id;
        }
    }
}
