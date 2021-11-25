using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Security.Claims;

namespace Csrs.Test.Controllers
{
    public abstract class ControllerTest<TController> where TController : ControllerBase
    {
        protected Mock<ILogger<TController>> GetMockLogger(bool strict = false) => new(strict ? MockBehavior.Strict : MockBehavior.Default);
        protected Mock<IMediator> GetMockMediator(bool strict = false) => new(strict ? MockBehavior.Strict : MockBehavior.Default);

        protected ClaimsPrincipal CreateUser(Guid id)
        {
            return new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim("bceid_userid", id.ToString()) }));
        }
    }
}
