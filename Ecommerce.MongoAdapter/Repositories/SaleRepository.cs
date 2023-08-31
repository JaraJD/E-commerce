using Ardalis.GuardClauses;
using AutoMapper;
using Ecommerce.Application.Features.Commands.SaleCommands;
using Ecommerce.Application.Gateway.Repository;
using Ecommerce.Domain.Entities;
using Ecommerce.MongoAdapter.EntitiesMongo;
using Ecommerce.MongoAdapter.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Ecommerce.MongoAdapter.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly IMongoCollection<SaleMongo> coleccionSale;
        private readonly IMongoCollection<ProductMongo> coleccionProduct;
        private readonly IMapper _mapper;

        public SaleRepository(IContext context, IMapper mapper)
        {
            coleccionSale = context.Sale;
            coleccionProduct = context.Product;
            _mapper = mapper;
        }

        public async Task<string> CreateSaleAsync(Sale sale)
        {
            Guard.Against.Null(sale, nameof(sale));
            foreach(var product in sale.products)
            {
                var filter = Builders<ProductMongo>.Filter.And(
                                Builders<ProductMongo>.Filter.Eq(b => b.ProductId, product.ProductId),
                                Builders<ProductMongo>.Filter.Eq(b => b.IsDeleted, false));

                var productToUpdate = await coleccionProduct.Find(filter).FirstOrDefaultAsync();

                if (productToUpdate.Stock < product.Quantity)
                {
                    throw new ArgumentException("Not enough products for purchase");
                }

                productToUpdate.Stock -= product.Quantity;

                var update = Builders<ProductMongo>.Update.Set(b => b.Stock, productToUpdate.Stock);

                await coleccionProduct.UpdateOneAsync(filter, update);
            }

            await coleccionSale.InsertOneAsync(_mapper.Map<SaleMongo>(sale));
            return "Sale Created".ToJson();
        }

        public async Task<string> DeleteSaleAsync(DeleteSaleCommand saleId)
        {
            var filter = Builders<SaleMongo>.Filter.Eq(b => b.SaleId, saleId.SaleId);
            var saleToDelete = await coleccionSale.Find(filter).FirstOrDefaultAsync();

            Guard.Against.Null(saleToDelete, nameof(saleToDelete));

            saleToDelete.IsDeleted = true;
            var updateResult = await coleccionSale.ReplaceOneAsync(filter, saleToDelete);

            return "Sale Eliminated".ToJson();
        }

        public async Task<List<Sale>> GetAllSalesAsync()
        {
            var sales = await coleccionSale.FindAsync(Builders<SaleMongo>.Filter.Eq(b => b.IsDeleted, false));
            var saleList = sales.ToEnumerable().Select(x => _mapper.Map<Sale>(x)).ToList();
            if (saleList.Count == 0)
            {
                throw new Exception("Sales not found.");
            }

            return saleList;
        }

        public async Task<Sale> GetSaleByIdAsync(string saleId)
        {
            var filter = Builders<SaleMongo>.Filter.And(
                                Builders<SaleMongo>.Filter.Eq(b => b.SaleId, saleId),
                                Builders<SaleMongo>.Filter.Eq(b => b.IsDeleted, false));

            var sale = await coleccionSale.Find(filter).FirstOrDefaultAsync();

            return _mapper.Map<Sale>(sale);
        }

        public async Task<string> UpdateSaleAsync(UpdateSaleCommand sale)
        {
            Guard.Against.NullOrEmpty(sale.SaleId, nameof(sale.SaleId));

            var filter = Builders<SaleMongo>.Filter.Eq(b => b.SaleId, sale.SaleId);
            var update = Builders<SaleMongo>.Update.Set(b => b.StoreId, sale.StoreId)
                                                      .Set(b => b.UserId, sale.UserId)
                                                      .Set(b => b.TotalPrice, sale.TotalPrice)
                                                      .Set(b => b.TransaccionTime, sale.TransaccionTime);

            await coleccionSale.UpdateOneAsync(filter, update);

            return "Sake Updated".ToJson();
        }
    }
}
