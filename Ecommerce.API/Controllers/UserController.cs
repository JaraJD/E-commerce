using Ecommerce.Application.Features.Queries.UserQueries;
using Ecommerce.Application.Gateway;
using Ecommerce.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserUseCase _userUseCase;
        public UserController(IUserUseCase userUseCase)
        {
            _userUseCase = userUseCase;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<List<UserQueryVm>> GetAll()
        {
            return await _userUseCase.GetAllUsers();
        }
    }
}
