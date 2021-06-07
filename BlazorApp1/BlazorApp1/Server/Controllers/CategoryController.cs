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
    public class CategoryController : ControllerBase
    {
        public DBContext db;
        public CategoryController()
        {
            db = new DBContext();
        }

        [HttpGet]
        public List<Category> Get()
        {
            return db.GetCategories();
        }

        [HttpGet("{id}")]
        public List<Category> GetByProductId(int id)
        {
            return db.getCategoryByProductId(id);
        }
    }
}
