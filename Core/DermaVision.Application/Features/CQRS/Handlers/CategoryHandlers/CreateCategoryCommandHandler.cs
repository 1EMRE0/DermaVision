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
    public class CreateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;

        public CreateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCategoryCommand command)
        {
            await _repository.CreateAsync(new Category
            {
                Name = command.Name
            });
        }
    }
}
