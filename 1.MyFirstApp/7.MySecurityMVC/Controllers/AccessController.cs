using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7.MySecurityMVC.Controllers
{
    [Authorize(Users = "josufmc@hotmail.com")]
    public class AccessController : Controller
    {
        // GET: Access
        public ContentResult Private()
        {
            return Content("This is private content");
        }

        [AllowAnonymous]
        public ContentResult Public()
        {
            return Content("This is public content");
        }
    }
}