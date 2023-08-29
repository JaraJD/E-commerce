using MongoDB.Bson.Serialization.Attributes;

namespace Ecommerce.MongoAdapter.EntitiesMongo
{
    public class CategoryMongo
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
