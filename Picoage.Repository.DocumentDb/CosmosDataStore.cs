using Azure.Identity;
using Microsoft.Azure.Cosmos;
using System.Linq.Expressions;

namespace Picoage.Repository.DocumentDb
{
    public class CosmosDataStore<TEntity> : IDataStore<TEntity> where TEntity : IIdompotent
    {
        private readonly Container container; 
        public CosmosDataStore()
        {
            CosmosClient client = new(
            accountEndpoint: "AZURE_COSMOS_DB_NOSQL_ENDPOINT", tokenCredential: new DefaultAzureCredential());
            Database database = client.GetDatabase("cosmicworks"); 
            container = database.GetContainer("Testcontainer");
        }

        public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
            //await container.ReadItemAsync<TEntity>(id: predicate, partitionKey: new PartitionKey("")); 
        }

        public async Task UpsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }


    }
}
