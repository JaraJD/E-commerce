using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Application.Features.Commands.StoreCommands
{
    public class DeleteStoreCommand
    {
        [Required]
        public string StoreId { get; set; }
    }
}
