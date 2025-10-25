using DermaVision.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DermaVision.Application.Features.CQRS.Commands.CategoryCommands
{
    public class CreateCategoryCommand
    {
        //public int CategoryId { get; set; } categoryid kullanmıyorum
        public string? Name { get; set; }

    }
}
