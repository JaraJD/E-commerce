using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Features.Commands.CategoryCommands
{
    public class UpdateCategoryCommand
    {
        [Required]
        public Guid CategoryId { get; set; }

        [StringLength(50)]
        public string? Name { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }
    }
}
