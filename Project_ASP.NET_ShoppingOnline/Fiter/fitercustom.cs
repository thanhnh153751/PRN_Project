using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using Project_ASP.NET_ShoppingOnline.Models;
using System;

namespace Project_ASP.NET_ShoppingOnline.Fiter
{
    public class fitercustom : Attribute, IAuthorizationFilter
    {
        public fitercustom()
        {

        }


        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string session = context.HttpContext.Session.GetString("acc");
            if (session is null)
            {
                context.Result = new RedirectToRouteResult
                (
                new RouteValueDictionary(new
                {
                    action = "Home",
                    controller = "home"
                }));
            }
            else
            {
                Customer account = JsonConvert.DeserializeObject<Customer>(session);
                if (account.Role != 1)
                {
                    context.Result = new RedirectToRouteResult
                 (
                 new RouteValueDictionary(new
                 {
                     action = "Home",
                     controller = "Home"
                 }));
                }
            }
        }
    }
}
