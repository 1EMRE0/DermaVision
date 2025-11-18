using DermaVision.Application.Interfaces;
using DermaVision.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DermaVision.Application.Features.CQRS.Commands.ProductCommands
{
    public class CreateProductCommand
    {
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public string ProductImageUrl { get; set; }

        public int CategoryId { get; set; }

        public string SkinType { get; set; } //ürünün hangi cilt tipi ile uygun olduğu.
    }
}
