using DermaVision.Application.Features.CQRS.Quaries.CategoryQuaries;
using DermaVision.Application.Features.CQRS.Results.Category;
using DermaVision.Application.Interfaces;
using DermaVision.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DermaVision.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetByIdCategoryQueryHandler
    {
        private readonly IRepository<Category> _repository;
        public GetByIdCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoryQueryByIdResult> Handle(GetCategoryByIdQuary query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCategoryQueryByIdResult
            {
                CategoryId = values.CategoryId,
                Name = values.Name
            };
                
            
                
        }
    }
}
