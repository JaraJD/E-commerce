using Ecommerce.Application.Features.Commands.StoreCommands;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Gateway.Repository
{
    public interface IStoreRepository
    {
        Task<string> CreateStoreAsync(Store store);

        Task<string> UpdateStoreAsync(UpdateStoreCommand store);

        Task<string> DeleteStoreAsync(DeleteStoreCommand storeId);

        Task<List<Store>> GetAllStoreAsync();

        Task<Store> GetStoreByIdAsync(string storeId);
    }
}
