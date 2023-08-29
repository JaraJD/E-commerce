using MongoDB.Bson.Serialization.Attributes;

namespace Ecommerce.MongoAdapter.EntitiesMongo
{
    public class StoreMongo
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string StoreId { get; set; }
        public string Name { get; set; }
        public string Site { get; set; }
        public bool IsDeleted { get; set; }
    }
}
