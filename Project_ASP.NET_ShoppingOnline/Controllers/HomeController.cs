using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project_ASP.NET_ShoppingOnline.Logics;
using Project_ASP.NET_ShoppingOnline.Models;
using System;
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

            var listProductMostView = productManager.GetTopViewProducts();
            //ViewBag.TopViewProducts = listProductMostView;

            string? json = HttpContext.Session.GetString("acc");
            Customer c = null;
            if (json != null) c = JsonConvert.DeserializeObject<Customer>(json);
            ViewBag.Customer = c;


            OrderManager ordersManager = new OrderManager();
            int si = 0;
            int OderId = 0;
            if (c != null)
            {
                //lấy size của giỏ hàng
                si = ordersManager.getSizeOfCart(c);

                //lấy OrderId từ account
                if (ordersManager.getOrder(c) == null)
                {
                    OderId = 0;
                }
                else
                {
                    OderId = ordersManager.getOrder(c).OrderId;
                }

            }


            ViewBag.OderId = OderId;
            ViewBag.sizeCart = si;

            return View();
        }


        [HttpGet]
        public JsonResult ListProductMostView()
        {
            try
            {
                ProductManager productManager = new ProductManager();
                var listProductMostView = productManager.GetTopViewProducts();
                return Json(new { code = 666, ProMostView = listProductMostView, msg = "successfuly" });
            }
            catch (Exception e)
            {
                return Json(new { code = 444, msg = "failure" });
            }

        }



        public IActionResult Home2(int id, int page = 1 ,string key = null)
        {
            ProductManager productManager = new ProductManager();
            CategoryManager categoryManager = new CategoryManager();
            List<Product> products;
            if (key != null)
            {
                 products = productManager.GetProductsBySeachBox(key);
                 ViewBag.Key = key;
            }
            else
            {
                products = productManager.GetProductsByCategoryId(id);
            }
             

            List<Category> allcategories = categoryManager.GetAllCategories();
            ViewBag.Allcategories = allcategories;
            ViewBag.Products = products;
            ViewBag.CurenCid = id;


            string? json = HttpContext.Session.GetString("acc");
            Customer c = null;
            if (json != null) c = JsonConvert.DeserializeObject<Customer>(json);
            ViewBag.Customer = c;


            
            OrderManager ordersManager = new OrderManager();
            int si=0;
            int OderId=0;
            if (c != null)
            {
                //lấy size của giỏ hàng
                si = ordersManager.getSizeOfCart(c);

                //lấy OrderId từ account
                if (ordersManager.getOrder(c) == null)
                {
                    OderId = 0;
                }
                else
                {
                    OderId = ordersManager.getOrder(c).OrderId;
                }

            }
             
            
            ViewBag.OderId = OderId;
            ViewBag.sizeCart = si;


            const int PageSize = 8;
            var count = products.Count();
            var data = products.Skip((page - 1) * PageSize).Take(PageSize).ToList();
            ViewBag.MaxPage = (count / PageSize) - (count % PageSize == 0 ? 1 : 0);
            ViewBag.Page = page;
            return View(data);
        }


    }
}
