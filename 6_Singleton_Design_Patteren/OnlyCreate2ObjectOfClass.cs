using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Singleton_Design_Patteren
{
    public class OnlyCreate2ObjectOfClass
    {

        private static OnlyCreate2ObjectOfClass firstConnection=null;

        private static OnlyCreate2ObjectOfClass SecondConnection = null;

        private static object _lock=new object();

        public static int Counter = 1;
        private OnlyCreate2ObjectOfClass()
        {
            

        }

        public static OnlyCreate2ObjectOfClass GetInstance
        {

            get
            {
                lock (_lock)
                {
                    if (Counter==1)
                    {
                        firstConnection = new OnlyCreate2ObjectOfClass();
                        return firstConnection;
                    }
                    else if (Counter == 2)
                    {
                        SecondConnection = new OnlyCreate2ObjectOfClass();
                        return SecondConnection;
                    }
                    else
                    {

                        throw new Exception("Doesnt have any permission to made more than 2 object");
                    }
                    //counter++;
                }

            }

        }

        public int getCounter => Counter++;

    }
}
