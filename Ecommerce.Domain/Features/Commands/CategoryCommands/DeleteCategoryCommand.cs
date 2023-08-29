using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Features.Commands.CategoryCommands
{
    public class DeleteCategoryCommand
    {
        [Required]
        public Guid CategoryId { get; set; }
    }
}
