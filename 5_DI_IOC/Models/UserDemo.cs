using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_DI_IOC.Models
{
    public class UserDemo : IDemo
    {
        public string GetPassword()
        {
            return "ABC@1234";
        }
    }
}