using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Application.Features.Queries.CategoryQueries
{
    public class GetCategoryIdQuery
    {
        [Required]
        public string CategoryId { get; set; }
    }
}
