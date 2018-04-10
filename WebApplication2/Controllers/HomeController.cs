
using System.Globalization;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Filter;
using WebApplication2.Helpers;

namespace WebApplication2.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        [AuthorizeFilter]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Admin()
        {
            ViewBag.Message = "Admin page.";

            return View();
        }
    }
}