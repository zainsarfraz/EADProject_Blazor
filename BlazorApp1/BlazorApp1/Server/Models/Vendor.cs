using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Server.Models
{
    public class Vendor
    {
        public int Id { set; get; }
        public string name { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
