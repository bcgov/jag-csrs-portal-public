using Csrs.Api.Models.Dynamics;
using Simple.OData.Client;

namespace Csrs.Api.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected IODataClient Client { get; init; }

        protected Repository(IODataClient client)
        {
            Client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<TEntity> InsertAsync(TEntity entity, CancellationToken cancellationToken)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            entity = await Client.For<TEntity>().Set(entity).InsertEntryAsync(cancellationToken);
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken) 
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            entity = await Client.For<TEntity>().Set(entity).UpdateEntryAsync(cancellationToken);
            return entity;
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await Client.For<TEntity>().Filter(_ => _.Id == id).DeleteEntryAsync(cancellationToken);
        }

        public async Task DeleteAsync(TEntity entity, CancellationToken cancellationToken)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            if (entity.Id == null)
            {
                throw new ArgumentException("Entity Id is missing", nameof(entity));

            }

            await DeleteAsync(entity.Id.Value, cancellationToken);
        }

        public async Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            TEntity entity = await Client.For<TEntity>().Filter(_ => _.Id == id).FindEntryAsync();
            return entity;
        }
    }
}
