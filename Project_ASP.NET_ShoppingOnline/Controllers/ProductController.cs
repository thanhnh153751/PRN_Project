using Microsoft.AspNetCore.Mvc;
using Project_ASP.NET_ShoppingOnline.Logics;
using Project_ASP.NET_ShoppingOnline.Models;
using System.Collections.Generic;
using System.Linq;

namespace Project_ASP.NET_ShoppingOnline.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public JsonResult GetProductByCategoryId(int id)//id ở đây là categoryId
        //{
        //    ProductManager productManager = new ProductManager();
        //    List<Product> products = productManager.GetProductsByCategoryId(id);
            
        //    return Json(new { code = 666,listProduct = products,cid=id, msg = "successfuly" });
        //}

        [HttpGet]
        public JsonResult GetProductByCategoryId(int id, int page = 1)//id ở đây là categoryId
        {
            ProductManager productManager = new ProductManager();
            List<Product> products = productManager.GetProductsByCategoryId(id);

            const int PageSize = 8;
            var count = products.Count();
            var data = products.Skip((page - 1) * PageSize).Take(PageSize).ToList();
            var MaxPage = (count / PageSize) - (count % PageSize == 0 ? 1 : 0);

            return Json(new { code = 666, listProduct = data, cid = id,page = page,maxpage = MaxPage, msg = "successfuly" });
        }
    }
}
