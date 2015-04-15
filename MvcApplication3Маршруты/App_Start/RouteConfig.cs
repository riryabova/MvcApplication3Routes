using MvcApplication3Маршруты.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication3Маршруты
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            /*"{controller}/{action}/{id}", */

            routes.MapRoute(
               name: "home",
               url: "",
               defaults: new { controller = "Home", action = "Products" }
           );

            routes.MapRoute(
               name: "article",
               url: "product/{article}",
               defaults: new { controller = "product", action = "Index", name = "AB-123" },
                  constraints: new { 
                      name = "[A-Z]{2}-[0-9]{3}" 
                                    }
               );
            /*3*/
            routes.MapRoute(
                name: "print",
                url: "product/{article}/print",
                defaults: new { controller = "product", action = "print", name = "AB-123" },
                   constraints: new { 
                       name = "[A-Z]{2}-[0-9]{3}" 
                   }
                );

            /*4*/
            routes.MapRoute(
              name: "category",
              url: "products/{category}/{page}",
              defaults: new { controller = "product", action = "category", category = "vegetables", page = "1" },
                 constraints: new
                 {
                     category = "[a-z]+",
                     page = "[0-9]+"
                 }
              );
            /*5*/
            /*\products\date\xxx-xx-xx\yy (где xxxx-xx-xx - валидная дата, yy - номер страницы - по умолчанию 1)*/
            routes.MapRoute(
              name: "product4",
              url: "products/date/{date}/{page}",
              defaults: new { controller = "product", action = "date", date = "25.03.2015", page = "1" },
                 constraints: new
                 {
                     date = new productsRouteConstraint(),
                     //date = @"(0[1-9]|[12][0-9]|3[01])[-](0[1-9]|1[012])[-](19|20)\d\d",
                     page = "[0-9]+"
                 }
              );
        }
    }
}