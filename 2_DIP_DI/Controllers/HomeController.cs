using _2_DIP_DI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_DIP_DI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

      /*  private UserModel _userModel;

        public HomeController()
        {
            _userModel= new UserModel();  // Direct Dependecy hardcoded

        }

        public ActionResult Index()
        {
            string userName = _userModel.GetUserName();
            return Content(userName);
        }*/


        // Home controller depends on Interface(IUserModel)
        private  IUserModel _userModel;


        //constructor Injection

        public HomeController(IUserModel userModel)
        {
            _userModel = userModel;
        }
       

        
        public ActionResult Index()
        {
            string userName = _userModel.GetUserName();
            _userModel.Fun();

            if (string.IsNullOrEmpty(userName))
            {
                return Content("User name is not available.");
            }

            return Content($"{userName}");
        }




    }
}