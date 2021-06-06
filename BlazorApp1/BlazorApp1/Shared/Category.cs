using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Shared
{
    public class Category
    {
        public Category()
        {

        }
        public Category(int id,Product p,string name)
        {
            this.Id = id;
            this.product = p;
            this.categoryName = name;
        }
        public int Id { get; set; }
        public Product product { get; set; }
        public string categoryName { get; set; }
    }
}
