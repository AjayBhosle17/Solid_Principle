using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Singleton_Design_Patteren
{
    public class Singleton
    {
        private static Singleton _connection=null;
        private static object _locker = new object();

        public static int _counter = 0;
        private Singleton()
        {
            _counter = 0;
        }

        public static Singleton GetInstance
        {

            get
            {
                if (_connection == null)
                {

                    lock (_locker) {    // thread safety in multi threading    at a time 1 execute when 

                        if (_connection == null) { 
                        
                            _connection = new Singleton();
                        }
                        return _connection;
                    }
                    
                }return _connection;
            }
        }

        public static int GetCounter()
        {
            return _counter++;
        }
        public void  MessageData(string message)
        {
            Console.WriteLine(message);
        }
    }
}
