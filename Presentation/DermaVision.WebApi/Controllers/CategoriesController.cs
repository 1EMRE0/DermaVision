using DermaVision.Application.Features.CQRS.Commands.CategoryCommands;
using DermaVision.Application.Features.CQRS.Handlers.CategoryHandlers;
using DermaVision.Application.Features.CQRS.Quaries.CategoryQuaries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DermaVision.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CreateCategoryCommandHandler _createCategoryCommandHandler;
        private readonly GetByIdCategoryQueryHandler _getByIdCategoryQueryHandler;
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
        private readonly RemoveCategoryCommandHandler _RemoveCategoryCommandHandler;
        private readonly UpdateCategoryCommandHandler _UpdateCategoryCommandHandler;

        public CategoriesController(CreateCategoryCommandHandler createCategoryCommandHandler, GetByIdCategoryQueryHandler getByIdCategoryQueryHandler, GetCategoryQueryHandler getCategoryQueryHandler, RemoveCategoryCommandHandler removeCategoryCommandHandler, UpdateCategoryCommandHandler updateCategoryCommandHandler)
        {
            _createCategoryCommandHandler = createCategoryCommandHandler;
            _getByIdCategoryQueryHandler = getByIdCategoryQueryHandler;
            _getCategoryQueryHandler = getCategoryQueryHandler;
            _RemoveCategoryCommandHandler = removeCategoryCommandHandler;
            _UpdateCategoryCommandHandler = updateCategoryCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var value = await _getCategoryQueryHandler.Handle();
            return Ok(value);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var value = await _getByIdCategoryQueryHandler.Handle(new GetCategoryByIdQuary(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
        {
            await _createCategoryCommandHandler.Handle(command);
            return Ok("Category added.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _RemoveCategoryCommandHandler.Handle(new RemoveCategoryCommand(id));
            return Ok("Category deleted.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
            await _UpdateCategoryCommandHandler.Handle(command);
            return Ok("Category updated.");
        }
    }
}
