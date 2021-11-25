using Csrs.Api.Models;
using Csrs.Api.Repositories;
using MediatR;

namespace Csrs.Api.Features.Accounts
{
    public static class Lookups
    {
        public enum LookupsType
        {
            Unknown = 0,
            Gender,
            Province,
            Identity,
            Referral
        }

        public class Request : IRequest<Response>
        {
            public static readonly Request Gender = new(LookupsType.Gender);
            public static readonly Request Province = new(LookupsType.Province);
            public static readonly Request Identity = new(LookupsType.Identity);
            public static readonly Request Referral = new(LookupsType.Referral);

            public LookupsType Type { get; init; }

            private Request(LookupsType type)
            {
                Type = type;
            }
        }

        public class Response
        {
            public IList<OptionValue> Items { get; init; }

            public Response(IList<OptionValue> items)
            {
                if (items is null)
                {
                    throw new ArgumentNullException(nameof(items));
                }

                Items = items;
            }
        }
        public class Handler : IRequestHandler<Request, Response>
        {
            private readonly ICsrsPartyRepository _repository;
            private readonly ILogger<Handler> _logger;

            public Handler(ICsrsPartyRepository repository, ILogger<Handler> logger)
            {
                _repository = repository ?? throw new ArgumentNullException(nameof(repository));
                _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            }

            public async Task<Response> Handle(Request request, CancellationToken cancellationToken)
            {
                IList<OptionValue> items = Array.Empty<OptionValue>();

                switch (request.Type)
                {
                    case LookupsType.Gender:
                        items = await _repository.GetGenderPicklistAsync(cancellationToken);
                        break;
                    case LookupsType.Referral:
                        items = await _repository.GetReferralPicklistAsync(cancellationToken);
                        break;
                    case LookupsType.Province:
                        items = await _repository.GetProvincePicklistAsync(cancellationToken);
                        break;
                    case LookupsType.Identity:
                        items = await _repository.GetIdentityPicklistAsync(cancellationToken);
                        break;
                    default:
                        break;
                }

                return new Response(items);
            }
        }
    }
}
