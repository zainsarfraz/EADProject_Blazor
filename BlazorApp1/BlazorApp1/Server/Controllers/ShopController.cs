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
    public class ShopController : ControllerBase
    {
        public DBContext db;
        public ShopController()
        {
            db = new DBContext();
        }

        [HttpGet]
        public List<Shop> Get()
        {
            return db.GetShops();
        }
        [HttpPost]
        public void addShop(Shop s)
        {
            db.addShop(s);
        }

        [HttpGet("{id}")]
        public Shop GetById(int id)
        {
            return db.getShopById(id);
        }
    }
}
