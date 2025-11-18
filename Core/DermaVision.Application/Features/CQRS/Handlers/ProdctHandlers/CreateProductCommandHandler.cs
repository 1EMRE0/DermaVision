using DermaVision.Application.Features.CQRS.Commands.ProductCommands;
using DermaVision.Application.Interfaces;
using DermaVision.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DermaVision.Application.Features.CQRS.Handlers.ProdctHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly IRepository<Product> _repository;

        public CreateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateProductCommand command )
        {
            await _repository.CreateAsync(new Product
            {

                ProductDescription = command.ProductDescription,
                ProductImageUrl = command.ProductImageUrl,
                ProductName = command.ProductName,
                ProductPrice = command.ProductPrice,
                ProductStock = command.ProductStock,
                SkinType = command.SkinType,
                CategoryId = command.CategoryId


            });
        }
    }
}
