using Ecommerce.Application.Gateway;
using Ecommerce.Application.Gateway.Repository;
using Ecommerce.Domain.Features.Commands.CategoryCommands;
using Ecommerce.Domain.Features.Queries.CategoryQueries;

namespace Ecommerce.Application.UseCase
{
    public class CategoryUseCase : ICategoryUseCase
    {
        private readonly ICategoryRepository _repository;

        public CategoryUseCase(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> CreateCategory(CreateCategoryCommand category)
        {
            return await _repository.CreateCategoryAsync(category);
        }

        public async Task<string> DeleteCategory(DeleteCategoryCommand categoryId)
        {
            return await _repository.DeleteCategoryAsync(categoryId);
        }

        public async Task<CategoryQueryVm> GetCategoryeById(string categoryId)
        {
            return await _repository.GetCategoryByIdAsync(categoryId);
        }

        public async Task<string> UpdateCategory(UpdateCategoryCommand category)
        {
            return await _repository.UpdateCategoryAsync(category);
        }
    }
}
