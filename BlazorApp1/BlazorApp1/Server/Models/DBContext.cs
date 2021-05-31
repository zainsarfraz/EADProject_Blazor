using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Server.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Vendor> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Order { get; set; }
        public DbSet<Shop> Shop { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=blazorsite;Integrated Security=True");
        }
    }
}
