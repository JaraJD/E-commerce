using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities
{
    public class Sale
    {
        public Guid SaleId { get; set; }
        [Required]
        public Guid StoreId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public List<Product> products { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        [Required]
        public DateTime TransaccionTime { get; set; }

    }
}
