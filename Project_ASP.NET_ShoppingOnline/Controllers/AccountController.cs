using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project_ASP.NET_ShoppingOnline.Logics;
using Project_ASP.NET_ShoppingOnline.Models;

namespace Project_ASP.NET_ShoppingOnline.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult doLogin(string user = "",string pass = "")
        {
            CustomerManager customer = new CustomerManager();
            Customer c = customer.GetCustommerLogin(user, pass);
            if (c == null)
            {
                ViewBag.mess = "username or password wrong!!!";
                return View("~/Views/Account/Login.cshtml");
            }
            else
            {
                //set sesion
                string json = JsonConvert.SerializeObject(c);
                HttpContext.Session.SetString("acc", json);
                return RedirectToAction("home","Home");
            }
        }
        public IActionResult logout()
        {
            //string? json = HttpContext.Session.GetString("acc");
            HttpContext.Session.Remove("acc");
            return RedirectToAction("home", "Home");
        }

    }
}
