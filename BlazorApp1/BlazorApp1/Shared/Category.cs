using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Shared
{
    public class Category
    {
        public int Id { get; set; }
        public Product product { get; set; }
        public string categoryName { get; set; }
    }
}
