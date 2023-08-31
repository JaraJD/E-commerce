using Ecommerce.Application.Features.Commands.SaleCommands;
using Ecommerce.Application.Features.Queries.SaleQueries;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Gateway
{
    public interface ISaleUseCase
    {
        Task<string> CreateSale(CreateSaleCommand saleCommand);

        Task<string> UpdateSale(UpdateSaleCommand sale);

        Task<string> DeleteSale(DeleteSaleCommand saleId);

        Task<List<SaleQueryVm>> GetAllSales();

        Task<SaleQueryVm> GetSaleById(string saleId);
    }
}
