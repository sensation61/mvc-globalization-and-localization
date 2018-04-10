using System.Web;
using System.Web.Optimization;

namespace WebApplication2
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        //"~/Scripts/jquery-{version}.js"
                        "~/Scripts/jquery.min-1.11.0.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jquerymask").Include(
                      "~/Scripts/jquery.mask*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryajax").Include(
                      "~/Scripts/jquery.unobtrusive*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap-3.2.0/bootstrap.min.js",
                "~/Scripts/bootstrap-3.2.0/docs.min.js",
                "~/Scripts/bootstrap-3.2.0/bootstrap-confirmation.min.js",
                "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap-3.2.0/bootstrap.min.css",
                        "~/Content/bootstrap-4.0.0/css/bootstrap-grid.min.css",
                        "~/Content/bootstrap-3.2.0/docs.min.css",
                        "~/Content/bootstrap-3.2.0/style.css",
                      "~/Content/site.css"));
        }
    }
}
