using System.Web;
using System.Web.Mvc;
using System.Threading;
using System.Globalization;

using WebApplication2.Helpers;

namespace WebApplication2.Filter
{
    public class GlobalizationFilter : ActionFilterAttribute
    {      
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string cultureOnCookie = GetCultureOnCookie(filterContext.HttpContext.Request);

            string cultureOnURL = filterContext.RouteData.Values.ContainsKey("lang") ? 
                ((string)filterContext.RouteData.Values["lang"]) : GlobalHelper.DefaultCulture;

            string culture = (cultureOnCookie == null) ? ((string)filterContext.RouteData.Values["lang"]) : cultureOnCookie;

            if (!culture.Contains(cultureOnURL))
            {
                filterContext.HttpContext.Response.RedirectToRoute("Default", new
                {
                    lang = culture.Split('-')[0],
                    controller = filterContext.RouteData.Values["controller"],
                    action = filterContext.RouteData.Values["action"]
                });

                return;
            }

            SetCurrentCultureOnThread(culture);

            if (culture != MultiLanguageViewEngine.CurrentCulture)
            {
                (ViewEngines.Engines[0] as MultiLanguageViewEngine).SetCurrentCulture(culture);
            }

            base.OnActionExecuting(filterContext);
        }

        /*public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            string cultureOnCookie = GetCultureOnCookie(filterContext.HttpContext.Request);
            if (cultureOnCookie == null)
            {
                filterContext.HttpContext.Response.Cookies.Add(new HttpCookie(_cookieLangName, GlobalHelper.CurrentCulture));
            }
            else  {
                string cultureOnURL = filterContext.RouteData.Values.ContainsKey("lang") ?
                ((string)filterContext.RouteData.Values["lang"]) : GlobalHelper.DefaultCulture;

                if (cultureOnCookie != cultureOnURL)
                {
                    filterContext.HttpContext.Response.Cookies.Add(new HttpCookie(_cookieLangName, cultureOnURL));
                }
            }
            base.OnResultExecuting(filterContext);
        }*/

        private void SetCurrentCultureOnThread(string culture)
        {
            if (string.IsNullOrEmpty(culture))
                culture = GlobalHelper.DefaultCulture;

            GlobalHelper.SetCulture(culture);
        }

        private string GetCultureOnCookie(HttpRequestBase request)
        {
            var cookie = request.Cookies[GlobalTypes.CookieName];
            return cookie?.Value;
        }
    }
}