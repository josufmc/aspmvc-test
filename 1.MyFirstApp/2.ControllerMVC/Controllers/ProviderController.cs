using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2.ControllerMVC.Controllers
{
    public class ProviderController : Controller
    {
        // GET: Provider
        public string AllProvidersList()
        {
            return @"
                <ul>
                    <li>A</li>
                    <li>B</li>
                    <li>C</li>
                </ul>
            ";
        }
    }
}