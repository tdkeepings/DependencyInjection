﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Website {
    public class RouteConfig {

        public static void RegisterRoutes(RouteCollection routes) {
            routes.MapRoute(
                "Default",                                              
                "{controller}/{action}/{id}",                           
                new { controller = "Home", action = "Index", id = "" }  
            );
        }
    }
}