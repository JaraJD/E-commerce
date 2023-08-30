using AutoMapper;
using Ecommerce.Application.Features.Commands.CategoryCommands;
using Ecommerce.Application.Features.Queries.CategoryQueries;
using Ecommerce.Application.Gateway;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryUseCase _categorUseCase;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryUseCase categoryUseCase, IMapper mapper)
        {
            _categorUseCase = categoryUseCase;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<string> CreateBalance([FromBody] CreateCategoryCommand command)
        {
            return await _categorUseCase.CreateCategory(command);
        }

        [HttpGet("GetCategory")]
        public async Task<CategoryQueryVm> GetBalanceByUserId(GetCategoryIdQuery id)
        {
            return await _categorUseCase.GetCategoryeById(id);
        }
    }
}
