using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Shared
{
    public class Vendor
    {
        public Vendor()
        {

        }
        public Vendor(int id,string name,string contact,string email,string password)
        {
            this.Id = id;
            this.name = name;
            this.contact = contact;
            this.email = email;
            this.password = password;
        }
        public int Id { set; get; }
        public string name { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public string password { get; set; }

    }
}
