using Ecommerce.Application.Features.Commands.ProductCommands;
using Ecommerce.Application.Features.Queries.ProductQueries;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Gateway
{
    public interface IProductUseCase
    {
        Task<string> CreateProduct(CreateProductCommand product);

        Task<string> UpdateProduct(UpdateProductCommand product);

        Task<string> DeleteProduct(DeleteProductCommand productId);

        Task<List<ProductQueryVm>> GetAllProducts();

        Task<ProductQueryVm> GetProductById(string productId);
    }
}
