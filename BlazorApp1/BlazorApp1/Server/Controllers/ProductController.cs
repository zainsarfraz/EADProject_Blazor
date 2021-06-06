using BlazorApp1.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public DBContext db;
        public ProductController()
        {
            db =new DBContext();
        }

        [HttpGet]
        public List<Product> Get()
        {
            return db.GetProducts();
        }
  
        [HttpGet("{id}")]
        public Product GetById(int id)
        {
            return db.getProductById(id);
        }
        [HttpGet]
        [Route("VendorId/{id}")]
        public List<Product> GetProductsByVendorId(int id)
        {
            return db.GetProductsByVendorId(id);
        }

    }
}
