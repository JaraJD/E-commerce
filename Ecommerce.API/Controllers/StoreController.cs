﻿using Ecommerce.Application.Features.Commands.StoreCommands;
using Ecommerce.Application.Features.Queries.StoreQueries;
using Ecommerce.Application.Gateway;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {

        private readonly IStoreUseCase _storeUseCase;

        public StoreController(IStoreUseCase storeUseCase)
        {
            _storeUseCase = storeUseCase;
        }
        [Authorize]
        [HttpPost]
        public async Task<string> CreateStore([FromBody] CreateStoreCommand command)
        {
            return await _storeUseCase.CreateStore(command);
        }
        [Authorize]
        [HttpGet("GetAllStores")]
        public async Task<List<StoreQueryVm>> GetStore()
        {
            return await _storeUseCase.GetAllStore();
        }
        [Authorize]
        [HttpGet("GetStore/{id}")]
        public async Task<StoreQueryVm> GetStoreById(string id)
        {
            return await _storeUseCase.GetStoreById(id);
        }
        [Authorize]
        [HttpPut("UpdateStore")]
        public async Task<string> UpdateStore([FromBody] UpdateStoreCommand command)
        {
            return await _storeUseCase.UpdateStore(command);
        }
        [Authorize]
        [HttpDelete("DeleteStore")]
        public async Task<string> DeleteStore([FromBody] DeleteStoreCommand command)
        {
            return await _storeUseCase.DeleteStore(command);
        }
    }
}
