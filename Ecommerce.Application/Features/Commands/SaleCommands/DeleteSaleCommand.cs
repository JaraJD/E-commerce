using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Application.Features.Commands.SaleCommands
{
    public class DeleteSaleCommand
    {
        [Required]
        public string SaleId { get; set; }
    }
}
