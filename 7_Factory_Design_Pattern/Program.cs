namespace _7_Factory_Design_Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Plz enter Customer Type");

            string customerType =Console.ReadLine().ToUpper();

            
            Customer factory=CustomFactory.getInstance(customerType);
            
           
            factory.Print();

       
        }
    }
}
