using System.Web.Mvc;
using System.Web.Routing;

using WebApplication2.Helpers;

namespace WebApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.LowercaseUrls = true;

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "LocalizedDefault",
            //    url: "{lang}/{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    constraints: new { lang = "tr-TR|fr-FR|en-US" }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{lang}/{controller}/{action}/{id}",
                defaults: new { lang = "tr", controller = "Home", action = "Index", id= UrlParameter.Optional }
            );
        }
    }
}
