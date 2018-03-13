using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2.ControllerMVC.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
         public ActionResult Search(string name)
        {
            var input = Server.HtmlEncode(name);
            return Content(input);
            //return View();
        }

        [HttpGet]
        public ActionResult Search()
        {
            var input = "Http Get selector";
            return Content(input);
            //return View();
        }
    }
}