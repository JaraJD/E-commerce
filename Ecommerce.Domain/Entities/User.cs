using Ecommerce.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities
{
    public class User
    {
        public string UserId { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set;}
        public string? Password { get; set;}
        public Enums.Roles Role { get; set; }
        public string? Address { get; set; }
        public bool IsDeleted { get; set; }
    }
}
