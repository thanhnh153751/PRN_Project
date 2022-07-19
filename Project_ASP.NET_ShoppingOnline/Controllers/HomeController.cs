using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project_ASP.NET_ShoppingOnline.Logics;
using Project_ASP.NET_ShoppingOnline.Models;
using System.Collections.Generic;
using System.Linq;

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

            string? json = HttpContext.Session.GetString("acc");
            Customer c = null;
            if (json != null) c = JsonConvert.DeserializeObject<Customer>(json);
            ViewBag.Customer = c;

            return View();
        }

        public IActionResult Home2(int id, int page = 1)
        {
            ProductManager productManager = new ProductManager();
            CategoryManager categoryManager = new CategoryManager();
            List<Product> products = productManager.GetProductsByCategoryId(id);
            List<Category> allcategories = categoryManager.GetAllCategories();
            ViewBag.Allcategories = allcategories;
            ViewBag.Products = products;
            ViewBag.CurenCid = id;


            string? json = HttpContext.Session.GetString("acc");
            Customer c = null;
            if (json != null) c = JsonConvert.DeserializeObject<Customer>(json);
            ViewBag.Customer = c;

            const int PageSize = 8;
            var count = products.Count();
            var data = products.Skip((page - 1) * PageSize).Take(PageSize).ToList();
            ViewBag.MaxPage = (count / PageSize) - (count % PageSize == 0 ? 1 : 0);
            ViewBag.Page = page;
            return View(data);
        }


    }
}
