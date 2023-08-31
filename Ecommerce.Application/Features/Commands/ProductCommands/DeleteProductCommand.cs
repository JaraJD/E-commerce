using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Application.Features.Commands.ProductCommands
{
    public class DeleteProductCommand
    {
        [Required]
        public string ProductId { get; set; }
    }
}
