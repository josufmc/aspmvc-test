using _10.RegisterMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10.RegisterMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Register obj)
        {
            // Comprobamos validación de vista
            if (ModelState.IsValid)
            {
                MyRegisterEntities db = new Models.MyRegisterEntities();
                db.Registers.Add(obj);
                db.SaveChanges();
            }
            return View(obj);
        }
    }
}