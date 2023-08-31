using Ecommerce.Application.Features.Commands.StoreCommands;
using Ecommerce.Application.Features.Queries.StoreQueries;

namespace Ecommerce.Application.Gateway
{
    public interface IStoreUseCase
    {
        Task<string> CreateStore(CreateStoreCommand storeCommand);

        Task<string> UpdateStore(UpdateStoreCommand store);

        Task<string> DeleteStore(DeleteStoreCommand storeId);

        Task<List<StoreQueryVm>> GetAllStore();

        Task<StoreQueryVm> GetStoreById(string storeId);
    }
}
