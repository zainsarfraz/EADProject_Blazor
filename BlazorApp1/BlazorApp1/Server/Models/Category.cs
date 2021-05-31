using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Server.Models
{
    public class Category
    {
        public int Id { get; set; }
        public Product product { get; set; }
        public string categoryName { get; set; }
    }
}
