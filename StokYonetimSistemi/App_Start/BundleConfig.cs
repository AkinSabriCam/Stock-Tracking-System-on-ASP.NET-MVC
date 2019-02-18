using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace StokYonetimSistemi.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/BBundles/Script").Include(
                "~/Content/admin/vendor/jquery/jquery.min.js",
                "~/Content/admin/vendor/jquery-easing/jquery.easing.min.js",
                "~/Content/admin/vendor/datatables/jquery.dataTables.js",
                "~/Content/admin/vendor/bootstrap/js/bootstrap.bundle.min.js",
                "~/Content/admin/vendor/chart.js/Chart.min.js",
                "~/Content/admin/vendor/datatables/dataTables.bootstrap4.js",
                "~/Content/admin/js/sb-admin.min.js",
                "~/Content/admin/js/demo/datatables-demo.js",
                "~/Content/admin/js/demo/chart-area-demo.js",
                "~/Scripts/Custom1.js",
                "~/Scripts/AJAXProducts.js",
                "~/Scripts/bootbox.min.js",
                "~/Scripts/jquery.unobtrusive-ajax.min.js"
                ));
            bundles.Add(new StyleBundle("~/BBundles/Style").Include(
                "~/Content/admin/vendor/bootstrap/css/bootstrap.min.css",
                "~/Content/admin/vendor/fontawesome-free/css/all.min.css",
                "~/Content/admin/vendor/datatables/dataTables.bootstrap4.css",
                "~/Content/admin/css/sb-admin.css",
                "~/Content/customstyle.css"

                ));

            bundles.Add(new ScriptBundle("~/BundlesLayout/Script").Include(
                "~/Scripts/jquery-1.10.2.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/jquery.unobtrusive-ajax.min.js",
                 "~/Scripts/bootbox.min.js",
                "~/Scripts/Custom.js",
                "~/Scripts/AJAXProducts.js"
            ));

            bundles.Add(new StyleBundle("~/BundlesLayout/Style").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/customstyle.css"
                ));



           
        }
    }
}