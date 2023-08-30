using Ecommerce.Application.Features.Commands.CategoryCommands;
using Ecommerce.Application.Features.Queries.CategoryQueries;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Gateway.Repository
{
    public interface ICategoryRepository
    {
        Task<string> CreateCategoryAsync(Category category);

        Task<string> UpdateCategoryAsync(UpdateCategoryCommand category);

        Task<string> DeleteCategoryAsync(DeleteCategoryCommand categoryId);

        Task<CategoryQueryVm> GetCategoryByIdAsync(GetCategoryIdQuery categoryId);
    }
}
