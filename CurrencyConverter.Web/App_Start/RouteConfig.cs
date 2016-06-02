// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="">
//   Copyright © 2016 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.CurrencyConverter.Web
{
    using System.Web.Routing;

    using App.CurrencyConverter.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Add("Default", new DefaultRoute());
        }
    }
}
