using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Features.Queries.SaleQueries
{
    public class SaleQueryVm
    {
        public string SaleId { get; set; }
        public string StoreId { get; set; }
        public string UserId { get; set; }
        public List<Product> products { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime TransaccionTime { get; set; }
    }
}
