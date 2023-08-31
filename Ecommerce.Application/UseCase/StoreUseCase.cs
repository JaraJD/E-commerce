using AutoMapper;
using Ecommerce.Application.Features.Commands.StoreCommands;
using Ecommerce.Application.Features.Queries.StoreQueries;
using Ecommerce.Application.Gateway;
using Ecommerce.Application.Gateway.Repository;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.UseCase
{
    public class StoreUseCase : IStoreUseCase
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public StoreUseCase(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<string> CreateStore(Store store)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteStore(DeleteStoreCommand storeId)
        {
            throw new NotImplementedException();
        }

        public Task<List<StoreQueryVm>> GetAllStoreAsync()
        {
            throw new NotImplementedException();
        }

        public Task<StoreQueryVm> GetStoreByIdAsync(string storeId)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateStore(UpdateStoreCommand store)
        {
            throw new NotImplementedException();
        }
    }
}
