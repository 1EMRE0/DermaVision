using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DermaVision.Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; } 
        public string ProductImageUrl { get; set; }

        public int CategoryId { get; set; }

        public string SkinType { get; set; } //ürünün hangi cilt tipi ile uygun olduğu.

        public Category Category { get; set; } 

        public void UpdateStcok(int amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException("Stock amount cannot be negative");
            }
            ProductStock = amount;
        } // stok miktarı girişinin kontrolü. bu metod admin controller kısmında çağrılacak.

    }

    
}
