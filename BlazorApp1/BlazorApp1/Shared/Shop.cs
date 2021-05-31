using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Shared
{
    public class Shop
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string details { get; set; }
        public Vendor vendor { get; set; }
    }
}
