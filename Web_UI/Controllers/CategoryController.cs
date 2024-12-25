using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_UI.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        ICategoryBL _categoryBL;

        public CategoryController(ICategoryBL categoryBL)
        {
            _categoryBL = categoryBL;
        }

        public ActionResult Index()
        {

            // list<Category> => List<CategoryViewModel>

            // var categories = _categoryBL.GetAll();   // this way not work hence we use automapper

            var categories = _categoryBL.GetAll();

            return View(categories);
        }
    }
}