using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MvcApplication3Маршруты.App_Start
{
    public class productsRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            
            DateTime datetime;
            return DateTime.TryParse(values[parameterName].ToString(), out datetime);

        }
    }
}