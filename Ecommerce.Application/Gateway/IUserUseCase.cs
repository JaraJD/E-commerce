using Ecommerce.Application.Features.Queries.UserQueries;

namespace Ecommerce.Application.Gateway
{
    public interface IUserUseCase
    {
        Task<List<UserQueryVm>> GetAllUsers();
    }
}
