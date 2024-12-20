using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DIp_DI
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Start Program Here");
            Database obj1 = new Database();
            Customer obj = new Customer(obj1);

            List<string> data=obj.GetData();

            foreach (string s in data)
            {
                Console.WriteLine(s);
            }
        }
    }
}
