using AutoMapper;
using Ecommerce.Application.Features.Commands.StoreCommands;
using Ecommerce.Application.Gateway.Repository;
using Ecommerce.Domain.Entities;
using Ecommerce.MongoAdapter.EntitiesMongo;
using Ecommerce.MongoAdapter.Interfaces;
using MongoDB.Driver;

namespace Ecommerce.MongoAdapter.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private readonly IMongoCollection<StoreMongo> coleccionStore;
        private readonly IMapper _mapper;

        public StoreRepository(IContext context, IMapper mapper)
        {
            coleccionStore = context.Store;
            _mapper = mapper;
        }

        public Task<string> CreateStoreAsync(Store store)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteStoreAsync(DeleteStoreCommand storeId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Store>> GetAllStoreAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Store> GetStoreByIdAsync(string storeId)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateStoreAsync(UpdateStoreCommand store)
        {
            throw new NotImplementedException();
        }
    }
}
