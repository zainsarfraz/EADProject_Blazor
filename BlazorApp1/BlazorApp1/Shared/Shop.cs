using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Shared
{
    public class Shop
    {

        public Shop()
        {
            this.vendor = new Vendor();
        }
        public Shop(int id,string name,string details, Vendor v)
        {
            this.Id = id;
            this.name = name;
            this.details = details;
            this.vendor = v;
        }
        public int Id { get; set; }
        public string name { get; set; }
        public string details { get; set; }
        public Vendor vendor { get; set; }
    }
}
