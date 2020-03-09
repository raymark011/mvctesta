using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Profile() {

            ViewBag.Nagsuggest = "John Dino";
            return View(); 
        }

        public ActionResult Student() {

            ViewBag.id = "1";
            ViewBag.fname = "Sheena Ann";
            ViewBag.lname = "Ambrad";
            ViewBag.gender = "Female";
            return View();
            
        }
    }
}
