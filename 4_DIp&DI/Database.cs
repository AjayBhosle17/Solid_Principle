using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DIp_DI
{
    public class Database : IDatabase
    {
        public List<string> GetData()
        {
            return new List<string>() { "Product A", "Product B" };
        }
    }
}
