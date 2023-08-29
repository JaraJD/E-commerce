using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Features.Queries.CategoryQueries
{
    public class GetCategoryIdQuery
    {
        [Required]
        public Guid CategoryId { get; set; }
    }
}
