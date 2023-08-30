using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Application.Features.Commands.CategoryCommands
{
    public class UpdateCategoryCommand
    {
        [Required]
        public string CategoryId { get; set; }

        [StringLength(50)]
        public string? Name { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }
    }
}
