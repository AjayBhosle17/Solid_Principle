using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2_DIP_DI.Models
{
    /* public class UserModel
     {
         public string GetUserName()
         {
             return "Ajay Bhosle";
         }
     }*/

    public class UserModel : IUserModel
    {
        public string GetUserName()
        {
            return "Ajay Bhosle";
        }

        public void Fun()
        {
            Console.WriteLine("Fun Called");
        }
    }

    public class ApiUserModel : IUserModel
    {
        public string GetUserName() {

            return "API Model";
        }
        public void Fun()
        {
            Console.WriteLine("Fun Called");
        }
    }
}