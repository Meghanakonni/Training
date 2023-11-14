using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "MoviesByYear",
                url: "{Movies}/{MoviesByYear}/{id}",
                defaults: new { controller = "Movies", action = "MoviesByYear", id = UrlParameter.Optional }
            );
        }
    }
}
