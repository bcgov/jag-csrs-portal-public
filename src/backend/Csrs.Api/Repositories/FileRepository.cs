using Simple.OData.Client;

namespace Csrs.Api.Repositories
{
    public class FileRepository : Repository<Csrs.Api.Models.Dynamics.File>, IFileRepository
    {
        public FileRepository(IODataClient client) : base(client)
        {
        }
    }
}
