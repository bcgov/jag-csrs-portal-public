using Csrs.Api.Models;
using Csrs.Api.Repositories;
using MediatR;

namespace Csrs.Api.Features.PortalAccounts
{
    public static class Signup
    {
        public class Request : IRequest<Response>
        {
            public Request(PortalAccount account)
            {
                Account = account ?? throw new ArgumentNullException(nameof(account));
            }

            public PortalAccount Account { get; init; }
        }

        public class Response
        {
            public Response(string id)
            {
                Id = id ?? throw new ArgumentNullException(nameof(id));
            }

            public string Id { get; init; }
        }

        public class Handler : IRequestHandler<Request, Response>
        {
            private readonly IPartyRepository _repository;
            private readonly ILogger<Handler> _logger;

            public Handler(IPartyRepository repository, ILogger<Handler> logger)
            {
                _repository = repository ?? throw new ArgumentNullException(nameof(repository));
                _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            }

            public Task<Response> Handle(Request request, CancellationToken cancellationToken)
            {
                
                return Task.FromResult(new Response(string.Empty));
            }
        }
    }
}
