using Ecommerce.Domain.Entities;
using Ecommerce.MongoAdapter.EntitiesMongo;
using Ecommerce.MongoAdapter.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Ecommerce.MongoAdapter
{
    public class Context : IContext
    {
        private readonly IMongoDatabase _database;

        public Context(IOptions<MongoDbSettingsEntity> options)
        {
            MongoClient client = new MongoClient(options.Value.ConnectionString);
            _database = client.GetDatabase(options.Value.DatabaseName);
        }

        public IMongoCollection<CategoryMongo> Category => _database.GetCollection<CategoryMongo>("category");
        public IMongoCollection<ProductMongo> Product => _database.GetCollection<ProductMongo>("product");
        public IMongoCollection<SaleMongo> Sale => _database.GetCollection<SaleMongo>("sale");
        public IMongoCollection<StoreMongo> Store => _database.GetCollection<StoreMongo>("store");
    }
}
