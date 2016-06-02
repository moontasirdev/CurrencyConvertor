// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BundleConfig.cs" company="">
//   Copyright © 2016 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.CurrencyConverter.Web
{
    using System.Web;
    using System.Web.Optimization;

    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/content/css/app").Include("~/content/app.css", "~/content/strap/libs.min.css"));

            bundles.Add(new ScriptBundle("~/js/jquery").Include("~/scripts/vendor/jquery-{version}.js"));



            bundles.Add(new ScriptBundle("~/js/app").Include(
                "~/scripts/vendor/angular-ui-router.js",
                
                "~/scripts/vendor/angular-animate.js",
                "~/scripts/vendor/angular-sanitize.js",
                "~/scripts/filters.js",
                "~/scripts/services.js",
                "~/scripts/directives.js",
                "~/scripts/controllers.js",
                "~/scripts/app.js",
                "~/scripts/vendor/underscore/underscore-awesomer.min.js",
                "~/scripts/vendor/strap/angular-strap.js",
                "~/scripts/vendor/strap/angular-strap.tpl.js"
                ));
        }
    }
}
