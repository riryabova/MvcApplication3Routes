using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3Маршруты.Controllers
{
    public class productController : Controller
    {
        //
        // GET: /product/

        public ActionResult Index()
        {
            ViewBag.myText = "2 МАршрут с артикулом";
            return View();
        }

        public ActionResult print()
        {
            ViewBag.myText = "3 Маршрут для печати";
            return View();
        }

        public ActionResult category()
        {
            ViewBag.myText = " 4 Маршрут с категорией";
             return View();
        }

        public ActionResult date()
        {
            ViewBag.myText = "Здесь может быть ваша дата";
           return View();
        }
    }
}
