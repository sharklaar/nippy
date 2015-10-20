using System.Web.Optimization;

namespace Nippy
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.validate.unobtrusive.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/common.js",
                        "~/Scripts/knockout-3.3.0.js",
                        //"~/Scripts/custom/capture.js",
                        "~/Scripts/custom/ApplicationViewModel.js"));
            
            bundles.Add(new StyleBundle("~/bundles/styles").Include(
                      "~/Content/bootstrap.css",
                        "~/Content/Styles/Styles.css",
                      "~/Content/themes/base/*.css"));




            BundleTable.EnableOptimizations = true;
        }
    }
}
