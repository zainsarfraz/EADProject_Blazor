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
    public class VendorController : ControllerBase
    {
        DBContext db;
        public VendorController()
        {
            db = new DBContext();
        }

        

        [HttpPost]
        public void addVendor(Vendor v)
        {
            db.addVendor(v);
        }

        [HttpGet]
        public List<Vendor> get()
        {
            return db.getVendors();
        }
        [HttpGet]
        [Route("email")]
        public Vendor getByEmail(string email)
        {
            return db.getVendorByEmail(email);
        }
    }
}
