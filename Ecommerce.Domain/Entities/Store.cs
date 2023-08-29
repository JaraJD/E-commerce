using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities
{
    public class Store
    {
        public string StoreId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Site { get; set; }

        public bool IsDeleted { get; set; }
    }
}
