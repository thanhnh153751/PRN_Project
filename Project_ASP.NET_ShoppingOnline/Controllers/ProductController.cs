using Microsoft.AspNetCore.Mvc;
using Project_ASP.NET_ShoppingOnline.Logics;
using Project_ASP.NET_ShoppingOnline.Models;
using System.Collections.Generic;

namespace Project_ASP.NET_ShoppingOnline.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetProductByCategoryId(int id)//id ở đây là categoryId
        {
            ProductManager productManager = new ProductManager();
            List<Product> products = productManager.GetProductsByCategoryId(id);
            
            return Json(new { code = 666,listProduct = products,cid=id, msg = "successfuly" });
        }
    }
}
