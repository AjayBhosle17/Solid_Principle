using _5_DI_IOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_DI_IOC.Controllers
{
    public class HomeController : Controller
    {

        IUserData obj;
        public HomeController(IUserData obj)
        {          
            this.obj = obj;

        }
        // GET: Home
        public ActionResult Index()
        {
            string name=obj.GetName();
            return Content(name);
        }
    }
}