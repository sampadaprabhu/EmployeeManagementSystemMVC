using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EmployeeManagementSystemMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Employee", action = "AddEmployee", id = UrlParameter.Optional }
            //);
            routes.MapRoute(
                "Employee/AddEmployee", "Employee/AddEmployee", 
                new { Controller = "Employee", action = "AddEmployee", id = UrlParameter.Optional }
                );
        }
    }
}
