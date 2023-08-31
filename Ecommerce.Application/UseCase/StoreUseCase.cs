using AutoMapper;
using Ecommerce.Application.Features.Commands.StoreCommands;
using Ecommerce.Application.Features.Queries.CategoryQueries;
using Ecommerce.Application.Features.Queries.StoreQueries;
using Ecommerce.Application.Gateway;
using Ecommerce.Application.Gateway.Repository;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.UseCase
{
    public class StoreUseCase : IStoreUseCase
    {
        private readonly IStoreRepository _repository;
        private readonly IMapper _mapper;

        public StoreUseCase(IStoreRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<string> CreateStore(CreateStoreCommand storeCommand)
        {
            var store = _mapper.Map<Store>(storeCommand);
            return await _repository.CreateStoreAsync(store);
        }

        public Task<string> DeleteStore(DeleteStoreCommand storeId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<StoreQueryVm>> GetAllStore()
        {
            var storesList = await _repository.GetAllStoreAsync();
            return _mapper.Map<List<StoreQueryVm>>(storesList);
        }

        public Task<StoreQueryVm> GetStoreById(string storeId)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateStore(UpdateStoreCommand store)
        {
            throw new NotImplementedException();
        }
    }
}
