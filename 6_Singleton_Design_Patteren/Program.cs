using System.Diagnostics.Metrics;

namespace _6_Singleton_Design_Patteren
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*     // For DatabaseConnection.cs  

                        DatabaseConnection db1 = DatabaseConnection.Instance;
                        int count = db1.getCounter();
                        Console.WriteLine($"Get Count : {count}");

                        count = db1.getCounter();
                        Console.WriteLine($"Get Count : {count}");

                        DatabaseConnection db2 = DatabaseConnection.Instance;
                        count = db2.getCounter();
                        Console.WriteLine($"Get Count : {count}");

                        count = db2.getCounter();
                        Console.WriteLine($"Get Count : {count}");*/


            // for Singleton.cs

            /* Singleton obj = Singleton.GetInstance;
             int count = Singleton.GetCounter();
             Console.WriteLine($"Get Count : {count}");
             obj.MessageData("Hey it is Singleton Pattern");

             count = Singleton.GetCounter();
             Console.WriteLine($"Get Count : {count}");
             obj.MessageData("Hey it is Singleton Pattern");


             Singleton obj1 = Singleton.GetInstance;
             int count1 = Singleton.GetCounter();
             Console.WriteLine($"Get Count : {count1}");
             obj1.MessageData("Hey it is Singleton Pattern");

             count1 = Singleton.GetCounter();
             Console.WriteLine($"Get Count : {count1}");
             obj1.MessageData("Hey it is Singleton Pattern");


             Console.WriteLine(ReferenceEquals(obj, obj1));   // true*/


            // For OnlyCreate2Object.cs


            try
            {
                OnlyCreate2ObjectOfClass obj = OnlyCreate2ObjectOfClass.GetInstance;
                int count1 = obj.getCounter;
                Console.WriteLine($"Get Count : {count1}");



                OnlyCreate2ObjectOfClass obj1 = OnlyCreate2ObjectOfClass.GetInstance;
                count1 = obj1.getCounter;
                Console.WriteLine($"Get Count : {count1}");


                Console.WriteLine($"\nrefernce Equal Or NOt: {ReferenceEquals(obj, obj1)}\n");  // False is correct beacus they are different

                OnlyCreate2ObjectOfClass obj2 = OnlyCreate2ObjectOfClass.GetInstance;
                count1 = obj2.getCounter;
                Console.WriteLine($"Get Count : {count1}");

               

            }
            catch (Exception ex) { 
            

                Console.WriteLine(ex.ToString());
            }




        }
    }
}
