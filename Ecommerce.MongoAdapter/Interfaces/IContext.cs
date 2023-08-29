using Ecommerce.MongoAdapter.EntitiesMongo;
using MongoDB.Driver;

namespace Ecommerce.MongoAdapter.Interfaces
{
    public interface IContext
    {
        public IMongoCollection<CategoryMongo> Category { get; }
        public IMongoCollection<ProductMongo> Product { get; }
        public IMongoCollection<SaleMongo> Sale { get; }
        public IMongoCollection<StoreMongo> Store { get; }
    }
}
