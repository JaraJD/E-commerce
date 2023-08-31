using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Application.Features.Commands.StoreCommands
{
    public class UpdateStoreCommand
    {
        [Required]
        public string StoreId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Site { get; set; }
    }
}
