using AutoMapper;
using Ecommerce.Application.Features.Queries.SaleQueries;
using Ecommerce.Application.Features.Queries.UserQueries;
using Ecommerce.Application.Gateway;
using Ecommerce.Application.Gateway.Repository;

namespace Ecommerce.Application.UseCase
{
    public class UserUseCase : IUserUseCase
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserUseCase(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<UserQueryVm>> GetAllUsers()
        {
            var usersList = await _repository.GetAllUsersAsync();
            return _mapper.Map<List<UserQueryVm>>(usersList);
        }
    }
}
