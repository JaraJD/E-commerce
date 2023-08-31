using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Application.Features.Commands.ProductCommands
{
    public class UpdateProductCommand
    {
        [Required]
        public string ProductId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        [Required]
        public string CategoryId { get; set; }

        [Required]
        public string StoreId { get; set; }

        public int Stock { get; set; }
    }
}
