using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities
{
    public class Category
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }

    }
}
