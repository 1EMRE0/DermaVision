using DermaVision.Application.Features.CQRS.Quaries.ProductQuries;
using DermaVision.Application.Features.CQRS.Results.ProductResult;
using DermaVision.Application.Interfaces;
using DermaVision.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DermaVision.Domain.Entities;

namespace DermaVision.Application.Features.CQRS.Handlers.ProdctHandlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly IRepository<Product> _repository;

        public GetProductByIdQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task<GetProductQueryByIdResult> Handle(GetProductByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetProductQueryByIdResult
            {
                CategoryId = values.CategoryId,
                ProductDescription = values.ProductDescription,
                ProductId = values.ProductId,
                ProductImageUrl = values.ProductImageUrl,
                ProductName = values.ProductName,
                ProductPrice = values.ProductPrice,
                ProductStock = values.ProductStock,
                SkinType = values.SkinType
            };
        }
    }
}
