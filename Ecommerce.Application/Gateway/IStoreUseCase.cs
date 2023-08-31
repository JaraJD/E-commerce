using Ecommerce.Application.Features.Commands.StoreCommands;
using Ecommerce.Application.Features.Queries.StoreQueries;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Gateway
{
    public interface IStoreUseCase
    {
        Task<string> CreateStore(Store store);

        Task<string> UpdateStore(UpdateStoreCommand store);

        Task<string> DeleteStore(DeleteStoreCommand storeId);

        Task<List<StoreQueryVm>> GetAllStoreAsync();

        Task<StoreQueryVm> GetStoreByIdAsync(string storeId);
    }
}
