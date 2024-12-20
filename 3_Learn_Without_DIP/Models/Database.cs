using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3_Learn_Without_DIP.Models
{
    public class Database : IDatabase
    {
        public List<string> GetProducts()
        {
            // Get products from the database
            return new List<string>() { "Product A", "Product B", "Product C" };
        }
    }
}