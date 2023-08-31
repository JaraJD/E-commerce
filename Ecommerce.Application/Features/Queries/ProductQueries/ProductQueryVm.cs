namespace Ecommerce.Application.Features.Queries.ProductQueries
{
    public class ProductQueryVm
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }
        public string StoreId { get; set; }
        public int Stock { get; set; }
    }
}
