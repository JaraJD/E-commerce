using Ecommerce.Application.Features.Queries.UserQueries;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Gateway.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsersAsync();
    }
}
