using Ecommerce.Application.Features.Commands.CategoryCommands;
using Ecommerce.Application.Features.Queries.CategoryQueries;

namespace Ecommerce.Application.Gateway
{
    public interface ICategoryUseCase
    {
        Task<string> CreateCategory(CreateCategoryCommand category);

        Task<string> UpdateCategory(UpdateCategoryCommand category);

        Task<string> DeleteCategory(DeleteCategoryCommand categoryId);

        Task<List<CategoryQueryVm>> GetAllCategories();

        Task<CategoryQueryVm> GetCategoryeById(string categoryId);
    }
}
