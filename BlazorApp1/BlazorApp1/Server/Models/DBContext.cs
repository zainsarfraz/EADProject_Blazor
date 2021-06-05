using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Server.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Shop> Shop { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=blazorsite;Integrated Security=True");
        }

        public List<Product> GetProducts()
        {
            var products = this.Product
                .ToList();

            return products;
        }

        public Product getProductById(int id)
        {
            var product = this.Product
               .Where(p => p.Id == id)
               .FirstOrDefault<Product>();

            return product;
        }

    }
}
