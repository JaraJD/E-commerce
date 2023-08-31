using Ecommerce.Domain.Entities;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.MongoAdapter.EntitiesMongo
{
    public class SaleMongo
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string SaleId { get; set; }
        public string StoreId { get; set; }
        public string UserId { get; set; }
        public List<ProductSaleItem> products { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime TransaccionTime { get; set; }

        public bool IsDeleted { get; set; }
    }
}
