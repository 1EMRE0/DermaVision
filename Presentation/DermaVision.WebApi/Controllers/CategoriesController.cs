using DermaVision.Application.Features.CQRS.Handlers.CategoryHandlers;
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
    }
}
