using MongoDB.Bson.Serialization.Attributes;

namespace Ecommerce.MongoAdapter.EntitiesMongo
{
    public class UserMongo
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string UserId { get; set; }
        public string? FullName { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public bool IsDeleted { get; set; }
    }
}
