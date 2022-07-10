using Microsoft.AspNetCore.Mvc;
using Project_ASP.NET_ShoppingOnline.Logics;
using Project_ASP.NET_ShoppingOnline.Models;
using System.Collections.Generic;

namespace Project_ASP.NET_ShoppingOnline.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            ProductManager productManager = new ProductManager();
            CategoryManager categoryManager = new CategoryManager();
            List<Product> newProducts = productManager.GetNewsProducts();
            List<Category> allcategories = categoryManager.GetAllCategories();
            ViewBag.Allcategories = allcategories;
            ViewBag.NewsProducts = newProducts;
            return View();
        }

    }
}
