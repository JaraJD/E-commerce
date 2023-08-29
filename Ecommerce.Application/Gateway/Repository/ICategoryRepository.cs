using Ecommerce.Domain.Features.Commands.CategoryCommands;
using Ecommerce.Domain.Features.Queries.CategoryQueries;

namespace Ecommerce.Application.Gateway.Repository
{
    public interface ICategoryRepository
    {
        Task<string> CreateCategoryAsync(CreateCategoryCommand category);

        Task<string> UpdateCategoryAsync(UpdateCategoryCommand category);

        Task<string> DeleteCategoryAsync(DeleteCategoryCommand categoryId);

        Task<CategoryQueryVm> GetCategoryByIdAsync(string categoryId);
    }
}
