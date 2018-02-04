﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Activity4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Test",
                url: "{Test}",
                defaults: new { controller = "test", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Button",
                url: "{Button}",
                defaults: new { controller = "button", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}