using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4.ViewMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public string MyController()
        {
            return "This is my controller";
        }

        public ActionResult MyView()
        {
            return View();
        }
    }
}