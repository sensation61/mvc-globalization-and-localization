using System.Web.Mvc;

using WebApplication2.Filter;

namespace WebApplication2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new GlobalizationFilter());
        }
    }
}
