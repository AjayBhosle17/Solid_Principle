using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Solid_Principle
{
    public abstract class Customer
    {


        public string customerType { get; set; }
        /* public void Insert()
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
         }*/

       // public abstract int GetTicketAmount();
        public void ShowsTiming()
        {
            Console.WriteLine("*** All Todays Shows ***");
        }

      //  public abstract void PrintTicket();
    }

    //LSP  =>  replace abstract to interface
    public interface ICustomer    {
          int GetTicketAmount();
          void PrintTicket();

        //not add here ISP
       // void freeFood(); // existing client forced 

    }

    // here i will manage ISP like freefood not force every person
    public interface Icustomer1 : ICustomer
    {
        void freeFood();
    }


    //ocp
    public class SilverCustomer : Customer, ICustomer
    {
        public  int GetTicketAmount()
        {
            return 200;
        }

        public   void PrintTicket()
        {
            Console.WriteLine("Silver Ticket Printed");
        }
    }
    public class GoldCustomer : Customer,ICustomer
    {
        public  int GetTicketAmount()
        {
            return 500;
        }

        public  void PrintTicket()
        {
            Console.WriteLine("Gold Ticket Printed");
        }
    }

    public class PlatinumCustomer : Customer,ICustomer
    {
        public  int GetTicketAmount()
        {
            return 700;
        }

        public  void PrintTicket()
        {
            Console.WriteLine("Platinum Ticket Printed");
        }
    }

    public class Enquiry : Customer 
    {
       /* public override int GetTicketAmount()
        {
            throw new NotImplementedException();
        }

        public override void PrintTicket()
        {
            throw new NotImplementedException();
        }*/
    }


    //ISP  interface most used

    //new client add existing without any forced another customer
    public class VIPCustomer : Customer, Icustomer1
    {
        public int GetTicketAmount()
        {

            return 1000;
        }

        public void PrintTicket()
        {
            Console.WriteLine("VIP Cutomer Ticket Printed");
        }

        public void freeFood()
        {
            Console.WriteLine("Free Food");
        }
    }
}
