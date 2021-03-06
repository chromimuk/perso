﻿using System.Web.Mvc;
using System.Web.Routing;

namespace MarconnetDotFr_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "",
                url: "work/idkcss",
                defaults: new { controller = "Work", action = "IDKCSS" }
            );
            routes.MapRoute(
                name: "",
                url: "work/{title}",
                defaults: new { controller = "Work", action = "Standard" }
            );

            routes.MapRoute(
                name: "AbraCanada",
                url: "AbraCanada",
                defaults: new { controller = "Misc", action = "AbraCanada" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}