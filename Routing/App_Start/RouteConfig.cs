using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // MapRoute needs namespace to disambiguate HomeController in different areas.
            string rootNamespace = typeof(Controllers.HomeController).Namespace;
            System.Diagnostics.Debug.Print("Namespace for Default route: " + rootNamespace);

            // Just because...
            routes.MapRoute(
                name: "Backwards",
                url: "{id}/{action}/{controller}",
                defaults: null,
                constraints: new { action = "Backwards" },
                namespaces: new[] { rootNamespace }
            );

            // ...and since optional parameters has to be the last url segment.
            routes.MapRoute(
                name: "Backwards_no_id",
                url: "{action}/{controller}",
                defaults: null,
                constraints: new { action = "Backwards" },
                namespaces: new[] { rootNamespace }
            );

            routes.MapRoute(
                name: "Date",
                url: "{controller}/{action}/{year}/{month}/{day}",
                defaults: null,
                constraints: new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" },
                namespaces: new[] { rootNamespace }
            );

            routes.MapRoute(
                name: "Mixed_params",
                url: "{controller}/{action}/{param}-{id}",
                defaults: null,
                constraints: new { param = @"\w+", id = @"\d+" },
                namespaces: new[] { rootNamespace }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { rootNamespace }
            );
        }
    }
}
