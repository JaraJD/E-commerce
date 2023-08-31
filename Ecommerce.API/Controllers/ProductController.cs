using AutoMapper;
using Ecommerce.Application.Features.Commands.ProductCommands;
using Ecommerce.Application.Features.Queries.ProductQueries;
using Ecommerce.Application.Gateway;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductUseCase _productUseCase;

        public ProductController(IProductUseCase productUseCase)
        {
            _productUseCase = productUseCase;
        }

        [HttpPost]
        public async Task<string> CreateProduct([FromBody] CreateProductCommand command)
        {
            return await _productUseCase.CreateProduct(command);
        }

        [Authorize]
        [HttpGet("GetAllProducts")]
        public async Task<List<ProductQueryVm>> GetProducts()
        {
            return await _productUseCase.GetAllProducts();
        }

        [HttpGet("GetProduct/{id}")]
        public async Task<ProductQueryVm> GetProductById(string id)
        {
            return await _productUseCase.GetProductById(id);
        }

        [HttpPut("UpdateProduct")]
        public async Task<string> UpdateProduct([FromBody] UpdateProductCommand command)
        {
            return await _productUseCase.UpdateProduct(command);
        }

        [HttpDelete("DeleteProduct")]
        public async Task<string> DeleteProduct([FromBody] DeleteProductCommand command)
        {
            return await _productUseCase.DeleteProduct(command);
        }
    }
}
