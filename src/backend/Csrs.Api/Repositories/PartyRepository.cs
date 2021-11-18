using Csrs.Api.Models.Dynamics;
using Simple.OData.Client;

namespace Csrs.Api.Repositories
{
    public class PartyRepository : Repository<Party>, IPartyRepository
    {
        public PartyRepository(IODataClient client) : base(client)
        {
        }
    }
}
