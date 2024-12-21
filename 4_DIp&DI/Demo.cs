using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DIp_DI
{
    public class Demo
    {
        private int x = 10;
        public class AB
        {
            public void Info()
            {
                Demo obj = new Demo();
                Console.WriteLine(obj.x);
            }
        }


        public static void Main(String[] args)
        {
           
            AB aB = new AB();
           aB.Info();


        }
    }
}
