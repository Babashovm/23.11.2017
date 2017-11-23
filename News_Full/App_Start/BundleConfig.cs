using System.Web;
using System.Web.Optimization;

namespace News_Full
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
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Assets/css").Include(

                "~/assets/css/bootstrap-3.1.1.min.css",
                "~/assets/css/owl.carousel.css",
                "~/assets/css/style.css",
                "~/assets/css/flexslider.css"
                )
                );

            bundles.Add(new ScriptBundle("~/Assets/script").Include(
                "~/assets/js/jquery.min.js",
                "~/assets/js/move-top.js",
                "~/assets/js/easing.js",
                "~/assets/js/responsiveslides.min.js",
                "~/assets/js/jquery.flexisel.js",
                "~/assets/js/owl.carousel.js",
                "~/assets/js/bootstrap-3.1.1.min.js"
                ));
        }
    }
}
