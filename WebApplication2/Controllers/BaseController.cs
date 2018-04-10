using System.Web;
using System.Web.Mvc;

using WebApplication2.Helpers;

namespace WebApplication2.Controllers
{
    public class BaseController : Controller
    {
        [HttpPost]
        public ActionResult ChangeCulture(string culture, string controller, string action, string id, string queryString)
        {
            var nameValues = HttpUtility.ParseQueryString(queryString);

            GlobalHelper.SetCulture(culture);

            var cookie = new HttpCookie(GlobalTypes.CookieName, culture);
            Response.Cookies.Add(cookie);

            var segments = Request.Url.Segments;

            var result = RedirectToRoute("Default", new
            {
                lang = GlobalHelper.CurrentCultureTwoLetterISOLanguageName,
                controller = controller,
                action = action,
                id = id
            });

            foreach (string item in nameValues)
            {
                result.RouteValues.Add(item, nameValues[item]);
            }

            return result;
        }
    }
}