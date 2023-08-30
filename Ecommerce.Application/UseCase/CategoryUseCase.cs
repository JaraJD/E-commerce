using AutoMapper;
using Ecommerce.Application.Features.Commands.CategoryCommands;
using Ecommerce.Application.Features.Queries.CategoryQueries;
using Ecommerce.Application.Gateway;
using Ecommerce.Application.Gateway.Repository;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.UseCase
{
    public class CategoryUseCase : ICategoryUseCase
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryUseCase(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<string> CreateCategory(CreateCategoryCommand categoryCommand)
        {
            var category = _mapper.Map<Category>(categoryCommand);
            return await _repository.CreateCategoryAsync(category);
        }

        public async Task<string> DeleteCategory(DeleteCategoryCommand categoryId)
        {
            return await _repository.DeleteCategoryAsync(categoryId);
        }

        public async Task<List<CategoryQueryVm>> GetAllCategories()
        {
            var categoriesList = await _repository.GetAllCategoriesAsync();
            return _mapper.Map<List<CategoryQueryVm>>(categoriesList);
        }
        

        public async Task<CategoryQueryVm> GetCategoryeById(string categoryId)
        {
            var category = await _repository.GetCategoryByIdAsync(categoryId);
            return _mapper.Map<CategoryQueryVm>(category);
        }

        public async Task<string> UpdateCategory(UpdateCategoryCommand category)
        {
            return await _repository.UpdateCategoryAsync(category);
        }
    }
}
