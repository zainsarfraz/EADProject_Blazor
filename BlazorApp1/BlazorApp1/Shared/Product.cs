using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Shared
{
    public class Product
    {

        public Product()
        {
            this.shop = new Shop();
        }
        public Product(int id,string name,string desc,double price,Shop s)
        {
            this.Id = id;
            this.name = name;
            this.description = desc;
            this.price = price;
            this.shop = s;
        }

        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public Shop shop { get; set; }

    }
}
