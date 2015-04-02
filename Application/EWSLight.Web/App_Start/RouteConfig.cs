using System.Web.Mvc;
using System.Web.Routing;

namespace EWSLight.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                 name: "Student_List",
                url: "Students",
                defaults: new { controller = "Student", action = "List" }
                );

            routes.MapRoute(
                name: "Student_Default",
                url: "Students/{id}",
                defaults: new {controller = "Student", action = "Get"}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
