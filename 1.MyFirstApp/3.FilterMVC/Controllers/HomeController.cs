﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3.FilterMVC.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        // GET: Home
        public string Index()
        {
            return "Home Controller";
        }

        [Authorize (Roles = "admin")]
        [OutputCache (Duration =10)]
        public string CurrentTime()
        {
            return DateTime.Now.ToString("T");
        }
    }
}