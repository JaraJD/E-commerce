using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities
{
    public class Product
    {
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public  string Name { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public string CategoryId { get; set; }

        [Required]
        public string StoreId { get; set; }

        [Range(0, int.MaxValue)]
        public int Stock { get; set; }

        public bool IsDeleted { get; set; }
    }
}
