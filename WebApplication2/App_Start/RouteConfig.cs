using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

        //http://localhost/Products.Edit.2
        //http://localhost/Docs/Products-Edit/2

            //routes.MapRoute(
            //    name: "Rule1",
            //    url: "{controller}.{action}.{id}",
            //    defaults: new { controller = "Products", action = "Edit", id = UrlParameter.Optional }
            //    );
            routes.MapRoute(
                name: "Rule2",
                url: "Docs/{controller}-{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                
                );

            routes.MapRoute(
                name: "Rule1",
                url: "{controller}.{action}.{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
