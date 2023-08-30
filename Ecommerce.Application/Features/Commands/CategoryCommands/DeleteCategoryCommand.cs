using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Application.Features.Commands.CategoryCommands
{
    public class DeleteCategoryCommand
    {
        [Required]
        public Guid CategoryId { get; set; }
    }
}
