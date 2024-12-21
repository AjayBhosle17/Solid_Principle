using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_DI_IOC.Models
{
    public class UserModel : IUserData
    {
        public string GetName()
        {
            return "Ajay Bhosle";
        }

    }
}