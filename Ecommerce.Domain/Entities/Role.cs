using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace Ecommerce.Domain.Entities
{
    [CollectionName("roles")]
    public class Role : MongoIdentityRole<Guid>
    {
    }
}
