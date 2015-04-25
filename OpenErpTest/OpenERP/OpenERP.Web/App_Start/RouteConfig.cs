using System.Web.Mvc;
using System.Web.Routing;

namespace OpenERP.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("static/*.html");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Invoice", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
