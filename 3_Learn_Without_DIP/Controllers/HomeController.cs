using _3_Learn_Without_DIP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_Learn_Without_DIP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        ProductService _pService;
        public HomeController() {

            Database obj = new Database();   // with DIP
            _pService = new ProductService(obj); //strongly dependent

        }
        public ActionResult Index()
        {
            var products = _pService.GetProducts();
            return View(products);
        }
    }
}