using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Solid_Principle
{
    public class Customer
    {
        public void Insert()
        {
            try
            {
                int a = 10, b = 0;
                Console.WriteLine(a);
                int x = a / b;

           
            }
            catch (Exception ex) {

                // single responsibility
               FileLogger fileLogger = new FileLogger();
                fileLogger.Log(ex.Message);
            }
        }

        public void Update()
        {
            try
            {
                int a = 10, b = 0;
                Console.WriteLine(a);
                int x = a / b;


            }
            catch (Exception ex)
            {

                File.AppendAllText(@"logs/Error.txt", $"{ex.Message}\n");
            }
        }
    }
}
