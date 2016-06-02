// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRoute.cs" company="">
//   Copyright © 2016 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.CurrencyConverter.Web.Routing
{
    using System.Web.Routing;

    public class DefaultRoute : Route
    {
        public DefaultRoute()
            : base("{*path}", new DefaultRouteHandler())
        {
            this.RouteExistingFiles = false;
        }
    }
}
