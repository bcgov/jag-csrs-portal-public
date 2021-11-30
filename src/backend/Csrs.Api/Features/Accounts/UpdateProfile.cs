﻿using AutoMapper;
using Csrs.Api.Models.Dynamics;
using Csrs.Api.Models;
using Csrs.Api.Repositories;
using MediatR;

namespace Csrs.Api.Features.Accounts
{
    public static class UpdateProfile
    {
        public class Request : IRequest<Response>
        {
            public Request(Account account)
            {
                Account = account ?? throw new ArgumentNullException(nameof(account));
            }

            public Account Account { get; init; }
        }

        public class Response
        {
            public Response(Account account)
            {
                Account = account ?? throw new ArgumentNullException(nameof(account));
            }

            public Account Account { get; init; }
        }

        public class Handler : IRequestHandler<Request, Response>
        {
            private readonly ICsrsPartyRepository _repository;
            private readonly IMapper _mapper;
            private readonly ILogger<Handler> _logger;

            public Handler(ICsrsPartyRepository repository, IMapper mapper, ILogger<Handler> logger)
            {
                _repository = repository ?? throw new ArgumentNullException(nameof(repository));
                _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
                _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            }

            public async Task<Response> Handle(Request request, CancellationToken cancellationToken)
            {
                SSG_CsrsParty party = _mapper.Map<SSG_CsrsParty>(request.Account);
                party = await _repository.UpdateAsync(party, cancellationToken);

                Account account = _mapper.Map<Account>(party);
                return new Response(account);
            }
        }
    }
}
