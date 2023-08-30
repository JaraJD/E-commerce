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
            //Guard.Against.NullOrEmpty(category.UserId, nameof(balance.UserId), "UserId Required. ");

            var categoryToCreate = new CategoryMongo
            {
              Name = category.Name,
              Description = category.Description,
              IsDeleted = false,
            };

            await coleccionCategory.InsertOneAsync(categoryToCreate);
            return "Category Created".ToJson();
        }

        public Task<string> DeleteCategoryAsync(DeleteCategoryCommand categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryQueryVm> GetCategoryByIdAsync(GetCategoryIdQuery categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateCategoryAsync(UpdateCategoryCommand category)
        {
            throw new NotImplementedException();
        }
    }
}
