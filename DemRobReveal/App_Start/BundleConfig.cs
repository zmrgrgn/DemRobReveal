using System.Web;
using System.Web.Optimization;

namespace DemRobReveal
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            #region Template Design

            bundles.Add(new ScriptBundle("~/template/js").Include(
                        "~/Scripts/jquery.min.js",
                        "~/Scripts/jquery-migrate.min.js",
                        "~/Scripts/bootstrap.bundle.min.js",
                        "~/Scripts/easing.min.js",
                        "~/Scripts/hoverIntent.js",
                        "~/Scripts/superfish.min.js",
                        "~/Scripts/wow.min.js",
                        "~/Scripts/owl.carousel.min.js",
                        "~/Scripts/magnific-popup.min.js",
                        "~/Scripts/sticky.js",
                        "~/Scripts/contactform.js",
                        "~/Scripts/main.js"));

            bundles.Add(new StyleBundle("~/template/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/animate.min.css",
                      "~/Content/css/ionicons.min.css",
                      "~/Content/css/owl.carousel.min.css",
                      "~/Content/css/magnific-popup.css",
                      "~/Content/css/ionicons.min.css",
                      "~/Content/css/style.css"));

            #endregion
        }
    }
}
