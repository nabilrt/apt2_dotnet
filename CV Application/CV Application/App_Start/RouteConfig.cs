using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CV_Application
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Student", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
              name: "Education",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Student", action = "Education", id = UrlParameter.Optional }
          );
            routes.MapRoute(
              name: "Projects",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Student", action = "Projects", id = UrlParameter.Optional }
          );
            routes.MapRoute(
              name: "References",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Student", action = "References", id = UrlParameter.Optional }
          );
        }
    }
}
