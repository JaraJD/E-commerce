using Ecommerce.Application.Features.Commands.ProductCommands;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Gateway.Repository
{
    public interface IProductRepository
    {
        Task<string> CreateProductAsync(Product product);

        Task<string> UpdateProductAsync(UpdateProductCommand product);

        Task<string> DeleteProductAsync(DeleteProductCommand productId);

        Task<List<Product>> GetAllProductsAsync();

        Task<Product> GetProductByIdAsync(string productId);
    }
}
