using Ardalis.GuardClauses;
using AutoMapper;
using Ecommerce.Application.Features.Commands.CategoryCommands;
using Ecommerce.Application.Features.Queries.CategoryQueries;
using Ecommerce.Application.Gateway.Repository;
using Ecommerce.Domain.Entities;
using Ecommerce.MongoAdapter.EntitiesMongo;
using Ecommerce.MongoAdapter.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Ecommerce.MongoAdapter.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IMongoCollection<CategoryMongo> coleccionCategory;
        private readonly IMapper _mapper;

        public CategoryRepository(IContext context, IMapper mapper)
        {
            coleccionCategory = context.Category;
            _mapper = mapper;
        }

        public async Task<string> CreateCategoryAsync(Category category)
        {
            Guard.Against.Null(category, nameof(category));

            await coleccionCategory.InsertOneAsync(_mapper.Map<CategoryMongo>(category));
            return "Category Created".ToJson();
        }

        public async Task<string> DeleteCategoryAsync(DeleteCategoryCommand categoryId)
        {
            var filter = Builders<CategoryMongo>.Filter.Eq(b => b.CategoryId, categoryId.CategoryId);
            var categoryToDelete = await coleccionCategory.Find(filter).FirstOrDefaultAsync();

            Guard.Against.Null(categoryToDelete, nameof(categoryToDelete));

            categoryToDelete.IsDeleted = true;
            var updateResult = await coleccionCategory.ReplaceOneAsync(filter, categoryToDelete);

            return "Category Eliminated".ToJson();
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            var categories = await coleccionCategory.FindAsync(Builders<CategoryMongo>.Filter.Eq(b => b.IsDeleted, false));
            var categoryList = categories.ToEnumerable().Select(x => _mapper.Map<Category>(x)).ToList();
            if (categoryList.Count == 0)
            {
                throw new Exception("Categories not found.");
            }

            return categoryList;
        }

        public async Task<Category> GetCategoryByIdAsync(string categoryId)
        {
            var filter = Builders<CategoryMongo>.Filter.And(
                                Builders<CategoryMongo>.Filter.Eq(b => b.CategoryId, categoryId),
                                Builders<CategoryMongo>.Filter.Eq(b => b.IsDeleted, false));

            var category= await coleccionCategory.Find(filter).FirstOrDefaultAsync();

            return _mapper.Map<Category>(category);
        }

        public async Task<string> UpdateCategoryAsync(UpdateCategoryCommand category)
        {
            Guard.Against.NullOrEmpty(category.CategoryId, nameof(category.CategoryId));

            if (category.Name == null && category.Description == null)
            {
                throw new ArgumentNullException("No information to update");
            }

            var filter = Builders<CategoryMongo>.Filter.Eq(b => b.CategoryId, category.CategoryId);
            var update = Builders<CategoryMongo>.Update.Set(b => b.Name, category.Name).Set(b => b.Description, category.Description);
            await coleccionCategory.UpdateOneAsync(filter, update);

            return "Category Updated".ToJson();
        }
    }
}
