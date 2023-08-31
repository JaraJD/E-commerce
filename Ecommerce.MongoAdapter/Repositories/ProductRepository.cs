using Ardalis.GuardClauses;
using AutoMapper;
using Ecommerce.Application.Features.Commands.ProductCommands;
using Ecommerce.Application.Gateway.Repository;
using Ecommerce.Domain.Entities;
using Ecommerce.MongoAdapter.EntitiesMongo;
using Ecommerce.MongoAdapter.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Ecommerce.MongoAdapter.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMongoCollection<ProductMongo> coleccionProduct;
        private readonly IMapper _mapper;

        public ProductRepository(IContext context, IMapper mapper)
        {
            coleccionProduct = context.Product;
            _mapper = mapper;
        }

        public async Task<string> CreateProductAsync(Product product)
        {
            Guard.Against.Null(product, nameof(product));

            await coleccionProduct.InsertOneAsync(_mapper.Map<ProductMongo>(product));
            return "Product Created".ToJson();
        }

        public async Task<string> DeleteProductAsync(DeleteProductCommand productId)
        {
            var filter = Builders<ProductMongo>.Filter.Eq(b => b.ProductId, productId.ProductId);
            var productToDelete = await coleccionProduct.Find(filter).FirstOrDefaultAsync();

            Guard.Against.Null(productToDelete, nameof(productToDelete));

            productToDelete.IsDeleted = true;
            var updateResult = await coleccionProduct.ReplaceOneAsync(filter, productToDelete);

            return "Product Eliminated".ToJson();
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            var products = await coleccionProduct.FindAsync(Builders<ProductMongo>.Filter.Eq(b => b.IsDeleted, false));
            var productList = products.ToEnumerable().Select(x => _mapper.Map<Product>(x)).ToList();
            if (productList.Count == 0)
            {
                throw new Exception("Products not found.");
            }

            return productList;
        }

        public async Task<Product> GetProductByIdAsync(string productId)
        {
            var filter = Builders<ProductMongo>.Filter.And(
                                Builders<ProductMongo>.Filter.Eq(b => b.ProductId, productId),
                                Builders<ProductMongo>.Filter.Eq(b => b.IsDeleted, false));

            var product = await coleccionProduct.Find(filter).FirstOrDefaultAsync();

            return _mapper.Map<Product>(product);
        }

        public async Task<string> UpdateProductAsync(UpdateProductCommand product)
        {
            Guard.Against.NullOrEmpty(product.ProductId, nameof(product.ProductId));

            var filter = Builders<ProductMongo>.Filter.Eq(b => b.ProductId, product.ProductId);
            var update = Builders<ProductMongo>.Update.Set(b => b.Name, product.Name)
                                                      .Set(b => b.Price, product.Price)
                                                      .Set(b => b.Description, product.Description)
                                                      .Set(b => b.CategoryId, product.CategoryId)
                                                      .Set(b => b.StoreId, product.StoreId)
                                                      .Set(b => b.Stock, product.Stock);

            await coleccionProduct.UpdateOneAsync(filter, update);

            return "Product Updated".ToJson();
        }
    }
}
