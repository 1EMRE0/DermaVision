using DermaVision.Application.Features.CQRS.Commands.CategoryCommands;
using DermaVision.Application.Interfaces;
using DermaVision.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DermaVision.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;

        public RemoveCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveCategoryCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
