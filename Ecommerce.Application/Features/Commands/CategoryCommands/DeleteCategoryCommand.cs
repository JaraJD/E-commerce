using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Application.Features.Commands.CategoryCommands
{
    public class DeleteCategoryCommand
    {
        [Required]
        public string CategoryId { get; set; }
    }
}
