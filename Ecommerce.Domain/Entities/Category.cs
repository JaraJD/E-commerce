using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities
{
    public class Category
    {
        public Guid CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

    }
}
