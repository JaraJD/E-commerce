using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.MongoAdapter.EntitiesMongo
{
    public class ProductMongo
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public Guid StoreId { get; set; }
        public int Stock { get; set; }
        public bool IsDeleted { get; set; }
    }
}
