namespace _1_Solid_Principle
{
    public class Program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("Program Starts here....");
            Customer customer = new Customer();

            customer.Insert();

            Console.WriteLine("Program Ends here....");
            Console.ReadLine();
        }
    }
}
