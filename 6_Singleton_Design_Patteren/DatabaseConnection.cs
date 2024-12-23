using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Singleton_Design_Patteren
{
    public class DatabaseConnection
    {
        public static  DatabaseConnection Connection;
        private int Counter;

        private DatabaseConnection()
        {
            Counter = 0;
        }

        public static  DatabaseConnection Instance
        {
            get
            {
                if (Connection == null)
                {
                    Connection = new DatabaseConnection();
                }
                return Connection;
            }
        }

        public int getCounter()
        {
            return Counter++;
        }
    }
}
