using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Shared
{
    class Product
    {
        public Product(int id,string name,string desc,double price)
        {
            this.Id = id;
            this.name = name;
            this.description = desc;
            this.price = price;
        }

        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }

    }
}
