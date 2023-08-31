using Ardalis.GuardClauses;
using AutoMapper;
using Ecommerce.Application.Features.Commands.StoreCommands;
using Ecommerce.Application.Gateway.Repository;
using Ecommerce.Domain.Entities;
using Ecommerce.MongoAdapter.EntitiesMongo;
using Ecommerce.MongoAdapter.Interfaces;
using MongoDB.Bson;
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

        public async Task<string> CreateStoreAsync(Store store)
        {
            Guard.Against.Null(store, nameof(store));

            await coleccionStore.InsertOneAsync(_mapper.Map<StoreMongo>(store));
            return "Store Created".ToJson();
        }

        public Task<string> DeleteStoreAsync(DeleteStoreCommand storeId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Store>> GetAllStoreAsync()
        {
            var sales = await coleccionStore.FindAsync(Builders<StoreMongo>.Filter.Eq(b => b.IsDeleted, false));
            var saleList = sales.ToEnumerable().Select(x => _mapper.Map<Store>(x)).ToList();
            if (saleList.Count == 0)
            {
                throw new Exception("Stores not found.");
            }

            return saleList;
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
