using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DIp_DI
{
    public class Customer:IDatabase
    {
        IDatabase _data;

        public Customer(IDatabase data)
        {
            _data = data;
        }
        public List<string> GetData()
        {
            return _data.GetData();
        }

    }
}
