using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Factory_Design_Pattern
{
    public class CustomFactory
    {

        static Dictionary<string, Customer> _customers;  // for 3way

        static CustomFactory()
        {
            _customers = new Dictionary<string, Customer>();
            _customers.Add("SILVER", new SilverCustomer());
            _customers.Add("GOlD", new GoldCustomer());
            _customers.Add("PLATINUM", new PlatinumCustomer());
        }

        public static Customer getInstance(string customerType)
        {

            // way 1

            /*  if (customerType == "SILVER")
              {
                  return new SilverCustomer();


              }
              else if (customerType == "GOLD")
              {
                  return new GoldCustomer();


              }
              else if(customerType =="PLATINUM")
              {
                  return new PlatinumCustomer();

              }
              else
              {
                  return new Customer();
              }*/


            // way 2

            /* switch (customerType)
             {

                 case "SILVER":
                     return new SilverCustomer();

                 case "GOLD":
                     return new GoldCustomer();

                 case "PLATINUM":
                     return new PlatinumCustomer();

                 default:
                     return new Customer();

             }*/


            // way3

            // without check condition
                
            if (_customers.ContainsKey(customerType)) { 
            
                  return _customers[customerType];
            }
            else
            {
                return new Customer();
            }
        }
    }
}
