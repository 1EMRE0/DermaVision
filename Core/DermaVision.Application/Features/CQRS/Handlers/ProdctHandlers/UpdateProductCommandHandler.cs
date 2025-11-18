using DermaVision.Application.Features.CQRS.Commands.CategoryCommands;
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
    public class UpdateProductCommandHandler
    {
        private readonly IRepository<Product> _repository;

        public UpdateProductCommandHandler(IRepository<Product> _repository)
        {
            _repository = _repository;
        }

        public async Task Handle(UpdateProductCommand command)
        {
            var value = await _repository.GetByIdAsync(command.ProductId);
            value.ProductId = command.ProductId;
            value.ProductName = command.ProductName;
            value.ProductPrice = command.ProductPrice;
            value.ProductStock = command.ProductStock;
            value.ProductDescription = command.ProductDescription;
            value.SkinType = command.SkinType;
            value.ProductImageUrl = command.ProductImageUrl;

            await _repository.UpdateAsync(value);
        }
    }
}
