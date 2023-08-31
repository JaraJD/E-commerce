using Ecommerce.Application.Features.Commands.SaleCommands;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Gateway.Repository
{
    public interface ISaleRepository
    {
        Task<string> CreateSaleAsync(Sale sale);

        Task<string> UpdateSaleAsync(UpdateSaleCommand sale);

        Task<string> DeleteSaleAsync(DeleteSaleCommand saleId);

        Task<List<Sale>> GetAllSalesAsync();

        Task<Sale> GetSaleByIdAsync(string saleId);
    }
}
