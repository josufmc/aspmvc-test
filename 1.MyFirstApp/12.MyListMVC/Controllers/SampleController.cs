using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _12.MyListMVC.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            List<string> list = new List<string>();
            list.Add("Choose");
            list.Add("Mexico");
            list.Add("Spain");
            list.Add("Argentina");

            SelectList countries = new SelectList(list);
            ViewData["countries"] = countries;

            return View();
        }

        [HttpPost]
        public JsonResult Provinces(string country)
        {
            List<string> listProv = new List<string>();
            switch (country)
            {
                case "Spain":
                    listProv.Add("Madrid");
                    listProv.Add("Galicia");
                    break;
                case "Mexico":
                    listProv.Add("Mexico DF");
                    listProv.Add("Yucatan");
                    break;
                case "Argentina":
                    listProv.Add("Buenos Aires");
                    listProv.Add("Rosario");
                    break;
            }
            return Json(listProv);
        }

    }
}