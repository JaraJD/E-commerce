using AutoMapper;
using Ecommerce.Application.Features.Commands.ProductCommands;
using Ecommerce.Application.Features.Commands.SaleCommands;
using Ecommerce.Application.Features.Queries.ProductQueries;
using Ecommerce.Application.Features.Queries.SaleQueries;
using Ecommerce.Application.Gateway;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {

        private readonly ISaleUseCase _saleUseCase;

        public SaleController(ISaleUseCase saleUseCase)
        {
            _saleUseCase = saleUseCase;
        }

        [Authorize]
        [HttpPost]
        public async Task<string> CreateSale([FromBody] CreateSaleCommand command)
        {
            return await _saleUseCase.CreateSale(command);
        }
        [Authorize]
        [HttpGet("GetAllSales")]
        public async Task<List<SaleQueryVm>> GetSales()
        {
            return await _saleUseCase.GetAllSales();
        }
        [Authorize]
        [HttpGet("GetSale/{id}")]
        public async Task<SaleQueryVm> GetSaleById(string id)
        {
            return await _saleUseCase.GetSaleById(id);
        }
        [Authorize]
        [HttpPut("UpdateSale")]
        public async Task<string> UpdateSale([FromBody] UpdateSaleCommand command)
        {
            return await _saleUseCase.UpdateSale(command);
        }
        [Authorize]
        [HttpDelete("DeleteSale")]
        public async Task<string> DeleteSale([FromBody] DeleteSaleCommand command)
        {
            return await _saleUseCase.DeleteSale(command);
        }
    }
}
