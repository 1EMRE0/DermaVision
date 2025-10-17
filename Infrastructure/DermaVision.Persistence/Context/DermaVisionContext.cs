using DermaVision.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DermaVision.Persistence.Context
{
    public class DermaVisionContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; initial Catalog=DermaVisionDb;integrated Security=true;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}


//Infrastructure / Persistence → Application ve Domain’in interface’lerini uygular

//protected sayesinde dışarıdan doğrudan çağrılamaz.
//