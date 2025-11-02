using DermaVision.Application.Features.CQRS.Results.ProductResult;
using DermaVision.Application.Interfaces;
using DermaVision.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DermaVision.Application.Features.CQRS.Handlers.ProdctHandlers
{
    public class GetProductQueryHandler
    {
        private readonly IRepository<Product> _repository;

        public GetProductQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetProductQueryResult
            {
                CategoryId = x.CategoryId,
                ProductDescription = x.ProductDescription,
                ProductId = x.ProductId,
                ProductImageUrl = x.ProductImageUrl,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice,
                ProductStock = x.ProductStock,
                SkinType = x.SkinType
            }).ToList();
            
        }
    }
}
