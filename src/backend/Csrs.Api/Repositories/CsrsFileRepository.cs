using Csrs.Api.Models.Dynamics;
using Simple.OData.Client;

namespace Csrs.Api.Repositories
{
    public class CsrsFileRepository : Repository<SSG_CsrsFile>, IFileRepository
    {
        public CsrsFileRepository(IODataClient client) : base(client)
        {
        }
    }
}
