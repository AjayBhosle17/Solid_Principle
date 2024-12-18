namespace _1_Solid_Principle
{
    public class Program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("Program Starts here....");
            // Customer customer = new Customer();


            //Ocp
            // it is not good way  so use inheritance
              Console.WriteLine("Enter Customer Type");
               string customerType = Console.ReadLine().ToUpper();
            /*
               if (customerType == "SILVER")
               {
                   customer.Insert();
               }else if (customerType == "Gold")
               {
                   customer.Insert();
               }*/
            //  customer.Insert();

            ICustomer c=null;

            if (customerType == "SILVER")
            {
                c=new SilverCustomer();
            }
            else if(customerType =="GOLD")
            {
                c=new GoldCustomer();
            }
            else if (customerType == "PLATINUM")
            {
                c = new GoldCustomer();
            }

            if (c != null)
            {
                c.PrintTicket();

            }
            else
            {
                Console.WriteLine("Invalid Customer");
            }

            Console.WriteLine("Program Ends here....");
            Console.ReadLine();

        //    ICustomer obj = new Enquiry();


           // why use above because  no change when new customer add we can add separte
        }
    }
}
