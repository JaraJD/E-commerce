using AutoMapper;
using Ecommerce.Application.Features.Commands.SaleCommands;
using Ecommerce.Application.Gateway.Repository;
using Ecommerce.Domain.Entities;
using Ecommerce.MongoAdapter.EntitiesMongo;
using Ecommerce.MongoAdapter.Interfaces;
using MongoDB.Driver;

namespace Ecommerce.MongoAdapter.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly IMongoCollection<SaleMongo> coleccionSale;
        private readonly IMapper _mapper;

        public SaleRepository(IContext context, IMapper mapper)
        {
            coleccionSale = context.Sale;
            _mapper = mapper;
        }

        public Task<string> CreateSaleAsync(Sale sale)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteSaleAsync(DeleteSaleCommand saleId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Sale>> GetAllSalesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Sale> GetSaleByIdAsync(string saleId)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateSaleAsync(UpdateSaleCommand sale)
        {
            throw new NotImplementedException();
        }
    }
}
