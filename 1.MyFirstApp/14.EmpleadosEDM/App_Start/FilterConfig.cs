﻿using System.Web;
using System.Web.Mvc;

namespace _14.EmpleadosEDM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
