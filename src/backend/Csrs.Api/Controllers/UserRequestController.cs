﻿using Csrs.Api.Features.UserRequests;
using Csrs.Api.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Csrs.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserRequestController : CsrsControllerBase<UserRequestController>
    {
        public UserRequestController(IMediator mediator, ILogger<UserRequestController> logger)
            : base(mediator, logger)
        {
        }

        [HttpPost("Create")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<string> CreateAsync([Required] UserRequest request2)
        {
            Create.Request request = new();
            Create.Response response = await _mediator.Send(request);

            return string.Empty;
        }
    }
}
