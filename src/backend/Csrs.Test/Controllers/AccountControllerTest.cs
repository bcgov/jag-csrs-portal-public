using Csrs.Api.Controllers;
using Csrs.Api.Features.Accounts;
using Csrs.Api.Models;
using Csrs.Api.Repositories;
using Microsoft.AspNetCore.Http;
using Moq;
using System;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Csrs.Test.Controllers
{
    public class AccountControllerTest : ControllerTest<AccountController>
    {
        [Fact]
        public void CanCreateController()
        {
            var logger = GetMockLogger();
            var mediator = GetMockMediator();

            new AccountController(mediator.Object, logger.Object);
        }

        [Fact]
        public void ControllerConstructorChecksParameters()
        {
            var logger = GetMockLogger();
            var mediator = GetMockMediator();

            Assert.Throws<ArgumentNullException>(() => new AccountController(null!, logger.Object));
            Assert.Throws<ArgumentNullException>(() => new AccountController(mediator.Object, null!));
        }

        [Fact]
        public async Task GetProfileShouldCreateCorrectRequest()
        {
            var logger = GetMockLogger();
            var mediator = GetMockMediator(true);
            var httpContextMock = new Mock<HttpContext>();

            mediator
                .Setup(_ => _.Send(It.IsAny<Profile.Request>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new Profile.Response())
                .Verifiable("Correct request was not sent.");

            var user = CreateUser(Guid.NewGuid());
            httpContextMock.Setup(_ => _.User).Returns(user);

            var sut = new AccountController(mediator.Object, logger.Object);
            sut.ControllerContext.HttpContext = httpContextMock.Object;

            var actual = await sut.GetProfileAsync(CancellationToken.None);

            mediator.Verify();
        }

        [Fact]
        public async Task SignupShouldCreateCorrectRequest()
        {
            var logger = GetMockLogger();
            var mediator = GetMockMediator(true);


            mediator
                .Setup(_ => _.Send(It.IsAny<Signup.Request>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new Signup.Response(Guid.NewGuid()))
                .Verifiable("Correct request was not sent.");

            var sut = new AccountController(mediator.Object, logger.Object);

            var actual = await sut.SignupAsync(new PortalAccount());

            mediator.Verify();
        }

        [Fact]
        public async Task UpdateProfileAsyncShouldCreateCorrectRequest()
        {
            var logger = GetMockLogger();
            var mediator = GetMockMediator(true);

            mediator
                .Setup(_ => _.Send(It.IsAny<UpdateProfile.Request>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new UpdateProfile.Response(new PortalAccount()))
                .Verifiable("Correct request was not sent.");

            var sut = new AccountController(mediator.Object, logger.Object);

            var actual = await sut.UpdateProfileAsync(new PortalAccount());

            mediator.Verify();
        }
    }
}
