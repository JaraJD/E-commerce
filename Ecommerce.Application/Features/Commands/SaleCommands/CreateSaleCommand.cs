using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Application.Features.Commands.SaleCommands
{
    public class CreateSaleCommand
    {
        [Required]
        public string StoreId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public DateTime TransaccionTime { get; set; }
    }
}
