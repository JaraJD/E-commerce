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
        private readonly ISaleRepository _repository;
        private readonly IMapper _mapper;

        public SaleUseCase(ISaleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<string> CreateSale(CreateSaleCommand saleCommand)
        {
            var sale = _mapper.Map<Sale>(saleCommand);
            return await _repository.CreateSaleAsync(sale);
        }

        public async Task<string> DeleteSale(DeleteSaleCommand saleId)
        {
            return await _repository.DeleteSaleAsync(saleId);
        }

        public async Task<List<SaleQueryVm>> GetAllSales()
        {
            var salessList = await _repository.GetAllSalesAsync();
            return _mapper.Map<List<SaleQueryVm>>(salessList);
        }

        public async Task<SaleQueryVm> GetSaleById(string saleId)
        {
            var sale = await _repository.GetSaleByIdAsync(saleId);
            return _mapper.Map<SaleQueryVm>(sale);
        }

        public async Task<string> UpdateSale(UpdateSaleCommand sale)
        {
            return await _repository.UpdateSaleAsync(sale);
        }
    }
}
