using AutoMapper;
using Ecommerce.Application.Features.Commands.CategoryCommands;
using Ecommerce.Application.Features.Queries.CategoryQueries;
using Ecommerce.Application.Gateway;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        [HttpPost]
        public async Task<string> CreateCategory([FromBody] CreateCategoryCommand command)
        {
            return await _categorUseCase.CreateCategory(command);
        }
        [Authorize]
        [HttpGet("GetAllCategories")]
        public async Task<List<CategoryQueryVm>> GetCategories()
        {
            return await _categorUseCase.GetAllCategories();
        }
        [Authorize]
        [HttpGet("GetCategory/{id}")]
        public async Task<CategoryQueryVm> GetCategoryById(string id)
        {
            return await _categorUseCase.GetCategoryeById(id);
        }
        [Authorize]
        [HttpPut("UpdateCategory")]
        public async Task<string> UpdateCategory([FromBody] UpdateCategoryCommand command)
        {
            return await _categorUseCase.UpdateCategory(command);
        }
        [Authorize]
        [HttpDelete("DeleteCategory")]
        public async Task<string> DeleteCategory([FromBody] DeleteCategoryCommand command)
        {
            return await _categorUseCase.DeleteCategory(command);
        }
    }
}
