using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace Ecommerce.Domain.Entities
{
    [CollectionName("users")]
    public class UserLogin : MongoIdentityUser<Guid>
    {
        public string FullName { get; set; } = string.Empty;

    }
}
