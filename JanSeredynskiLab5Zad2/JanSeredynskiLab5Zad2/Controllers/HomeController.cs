using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JanSeredynskiLab5Zad2.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Zwraca strone startową restauracji
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
           
            return View();
        }

    }
}
