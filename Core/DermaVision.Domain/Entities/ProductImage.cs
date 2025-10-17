using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DermaVision.Domain.Entities
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }

        public int ProductId { get; set; } // product sınıfyla ilişki kurmak için.
        public Product Product { get; set; }
    }
}
