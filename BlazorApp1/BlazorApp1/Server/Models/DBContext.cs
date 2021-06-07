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
                .Include(p => p.Shop)
                .Include(p => p.Shop.Vendor)
                .ToList();

            return products;
        }

        public Product getProductById(int id)
        {
            var product = this.Product
               .Where(p => p.Id == id)
               .Include(p => p.Shop)
               .Include(p => p.Shop.Vendor)
               .FirstOrDefault<Product>();

            return product;
        }

        public List<Shop> GetShops()
        {

            var shops = this.Shop
                .Include(s => s.Vendor)
                .ToList();

            return shops;
        }

        public Shop getShopById(int id)
        {
            var shop = this.Shop
                .Where(s => s.Id == id)
                .Include(s => s.Vendor)
                .FirstOrDefault<Shop>();

            return shop;
        }

        public List<Category> GetCategories()
        {

            var categories = this.Category
                .Include(c => c.product)
                .Include(c => c.product.Shop)
                .Include(c => c.product.Shop.Vendor)
                .ToList();

            return categories;
        }
        public List<Category> getCategoryByProductId(int id)
        {
            var category = this.Category
                .Where(c => c.product.Id == id)
                .Include(c => c.product)
                .ToList();

            return category;
        }

        public List<Product> GetProductsByVendorId(int id)
        {

            var products = this.Product
                .Include(p => p.Shop)
                .Include(p => p.Shop.Vendor)
                .Where(p => p.Shop.Vendor.Id == id)
                .ToList();

            return products;
        }

        public void deleteProductById(int id)
        {

            var product = new Product { Id = id };
            this.Category.RemoveRange(this.Category.Where(x => x.product == product));
            this.SaveChanges();
            this.Product.Attach(product);
            this.Product.Remove(product);
            this.SaveChanges();
        }

        public void addShop(Shop s)
        {
            this.Shop.Add(s);
            this.SaveChanges();
        }

        public void addVendor(Vendor vender)
        {
       
                this.Vendor.Add(vender);
                this.SaveChanges();
                
        }

        public List<Vendor> getVendors()
        {
            var vendors = this.Vendor
                .ToList();

            return vendors;
        }

        public Vendor getVendorByEmail(string email)
        {
            var vendor = this.Vendor
                .Where(v => v.email == email)
                .FirstOrDefault<Vendor>();

            return vendor;
        }
    }
}
