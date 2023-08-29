using Ecommerce.Domain.Features.Commands.CategoryCommands;
using Ecommerce.Domain.Features.Queries.CategoryQueries;

namespace Ecommerce.Application.Gateway
{
    public interface ICategoryUseCase
    {
        Task<string> CreateCategory(CreateCategoryCommand category);

        Task<string> UpdateCategory(UpdateCategoryCommand category);

        Task<string> DeleteCategory(DeleteCategoryCommand categoryId);

        Task<CategoryQueryVm> GetCategoryeById(string categoryId);
    }
}
