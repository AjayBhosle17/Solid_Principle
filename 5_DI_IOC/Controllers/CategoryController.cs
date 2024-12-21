using _5_DI_IOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_DI_IOC.Controllers
{
    public class CategoryController : Controller
    {

        IDemo _data;
        IUserData _userData;
        public CategoryController(IUserData obj,IDemo obj1)
        {
            _data = obj1;
            _userData = obj;

        }
        // GET: Category
        public ActionResult Index()
        {

            string password=_data.GetPassword();
            string username=_userData.GetName();


            return Content($"password:{password},username : {username}");
        }
    }
}