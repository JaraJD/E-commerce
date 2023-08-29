using Ecommerce.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities
{
    public class User
    {
        public string UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required]
        [StringLength(50)]
        public string? Username { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set;}
        [Required]
        public string? Password { get; set;}
        [Required]
        public Enums.Roles Role { get; set; }

        public string? Address { get; set; }
        public bool IsDeleted { get; set; }
    }
}
