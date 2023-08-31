using AutoMapper;
using Ecommerce.Application.Features.Commands.ProductCommands;
using Ecommerce.Application.Features.Queries.CategoryQueries;
using Ecommerce.Application.Features.Queries.ProductQueries;
using Ecommerce.Application.Gateway;
using Ecommerce.Application.Gateway.Repository;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.UseCase
{
    public class ProductUseCase : IProductUseCase
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductUseCase(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<string> CreateProduct(CreateProductCommand productCommand)
        {
            var product = _mapper.Map<Product>(productCommand);
            return await _repository.CreateProductAsync(product);
        }

        public async Task<string> DeleteProduct(DeleteProductCommand productId)
        {
            return await _repository.DeleteProductAsync(productId);
        }

        public async Task<List<ProductQueryVm>> GetAllProducts()
        {
            var productsList = await _repository.GetAllProductsAsync();
            return _mapper.Map<List<ProductQueryVm>>(productsList);
        }

        public async Task<ProductQueryVm> GetProductById(string productId)
        {
            var product = await _repository.GetProductByIdAsync(productId);
            return _mapper.Map<ProductQueryVm>(product);
        }

        public async Task<string> UpdateProduct(UpdateProductCommand product)
        {
            return await _repository.UpdateProductAsync(product);
        }
    }
}
