using AutoMapper;
using Ecommerce.Application.Features.Commands.SaleCommands;
using Ecommerce.Application.Features.Queries.SaleQueries;
using Ecommerce.Application.Gateway;
using Ecommerce.Application.Gateway.Repository;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.UseCase
{
    public class SaleUseCase : ISaleUseCase
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public SaleUseCase(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<string> CreateSale(Sale sale)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteSale(DeleteSaleCommand saleId)
        {
            throw new NotImplementedException();
        }

        public Task<List<SaleQueryVm>> GetAllSales()
        {
            throw new NotImplementedException();
        }

        public Task<SaleQueryVm> GetSaleById(string saleId)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateSale(UpdateSaleCommand sale)
        {
            throw new NotImplementedException();
        }
    }
}
