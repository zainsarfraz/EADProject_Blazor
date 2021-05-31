using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Server.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string details { get; set; }
        public Vendor Vendor { get; set; }
    }
}
