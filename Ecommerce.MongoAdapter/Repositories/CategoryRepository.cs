using AutoMapper;
using Ecommerce.MongoAdapter.EntitiesMongo;
using Ecommerce.MongoAdapter.Interfaces;
using MongoDB.Driver;

namespace Ecommerce.MongoAdapter.Repositories
{
    public class CategoryRepository
    {
        private readonly IMongoCollection<CategoryMongo> coleccionCategory;
        private readonly IMapper _mapper;

        public CategoryRepository(IContext context, IMapper mapper)
        {
            coleccionCategory = context.Category;
            _mapper = mapper;
        }
    }
}
