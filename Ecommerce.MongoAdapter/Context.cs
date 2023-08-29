using Ecommerce.MongoAdapter.EntitiesMongo;
using Ecommerce.MongoAdapter.Interfaces;
using MongoDB.Driver;

namespace Ecommerce.MongoAdapter
{
    public class Context : IContext
    {
        private readonly IMongoDatabase _database;

        public Context(string stringConnection, string DBname)
        {
            MongoClient client = new MongoClient(stringConnection);
            _database = client.GetDatabase(DBname);
        }

        public IMongoCollection<CategoryMongo> Category => _database.GetCollection<CategoryMongo>("category");
        public IMongoCollection<ProductMongo> Product => _database.GetCollection<ProductMongo>("product");
        public IMongoCollection<SaleMongo> Sale => _database.GetCollection<SaleMongo>("sale");
        public IMongoCollection<StoreMongo> Store => _database.GetCollection<StoreMongo>("store");
    }
}
