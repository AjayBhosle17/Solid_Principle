using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Factory_Design_Pattern
{
    public class Customer
    {

        public virtual void Print()
        {
            Console.WriteLine("Customer Print");
        }
    }

    public class SilverCustomer:Customer
    {

        public override void Print()
        {
            Console.WriteLine("Silver Customer Print");
        }
    }

    public class GoldCustomer:Customer
    {

        public override void Print()
        {
            Console.WriteLine("Gold Customer Print");
        }
    }

    public class PlatinumCustomer : Customer
    {

        public override void Print()
        {
            Console.WriteLine("Gold Customer Print");
        }
    }
}
