using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project_ASP.NET_ShoppingOnline.Logics;
using Project_ASP.NET_ShoppingOnline.Models;
using System;
using System.Collections.Generic;

namespace Project_ASP.NET_ShoppingOnline.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public JsonResult AddtoCart(int idP)
        {
            try
            {
                OrderManager ordersManager = new OrderManager();
                string? json = HttpContext.Session.GetString("acc");
                Customer  c = JsonConvert.DeserializeObject<Customer>(json);

                ordersManager.AddToCart(idP , c);
                int s = ordersManager.getSizeOfCart(c);
                //lấy OrderId từ account
                
                int OderId;
                if (ordersManager.getOrder(c) == null)
                {
                    OderId = 0;
                }
                else
                {
                    OderId = ordersManager.getOrder(c).OrderId;
                }

                return Json(new { code = 666, size = s, oid = OderId, msg = "successfuly" });

               

            }
            catch (Exception e)
            {
                return Json(new { code = 444, msg = "failure" });
            }

        }

        public IActionResult ViewCart(int id)//id ở đây là ordersId
        {
            OrderManager ordersManager = new OrderManager();
            List<OrdersDetail> listOrderDetails = ordersManager.getOrderDetail(id);

            try
            {
                //lấy OrderId từ account
                string? json = HttpContext.Session.GetString("acc");
                Customer c = JsonConvert.DeserializeObject<Customer>(json);

                int OderId;
                if (ordersManager.getOrder(c) == null)
                {
                    OderId = 0;
                }
                else
                {
                    OderId = ordersManager.getOrder(c).OrderId;
                }
                ViewBag.OderId = OderId;

                return View(listOrderDetails);
            }
            catch (Exception e)
            {
                return View("~/Views/Account/Login.cshtml");
            }
            
        }

        [HttpGet]
        public JsonResult SetNumberQuantity(int idOrder, int idP, int status)
        {
            try
            {
                OrderManager ordersManager = new OrderManager();
                ProductManager productManager = new ProductManager();
                int newQuan = ordersManager.SetNumberQuantity(idOrder, idP, status);
                Product p = productManager.GetProductById(idP);


                return Json(new { code = 666, newquan = newQuan,maxquan = p.UnitsInStock, msg = "successfuly" });
            }
            catch (Exception e)
            {
                return Json(new { code = 444, msg = "failure" });
            }

        }

        [HttpGet]
        public JsonResult DeleteItem(int idOrder, int idP)
        {
            try
            {
                OrderManager ordersManager = new OrderManager();
                ordersManager.DeleteItem(idOrder, idP);


                return Json(new { code = 666, msg = "successfuly" });
            }
            catch (Exception e)
            {
                return Json(new { code = 444, msg = "failure" });
            }

        }

        public IActionResult CheckOut(int id,int bill = 0)//id ở đây là ordersId
        {
            OrderManager ordersManager = new OrderManager();
            List<OrdersDetail> listOrderDetails = ordersManager.CheckOut(id,bill);

            return View(listOrderDetails);
        }

        [HttpGet]
        public JsonResult CheckValidationCart(int idOrder)//id ở đây là ordersId
        {
            OrderManager ordersManager = new OrderManager();
            List<OrdersDetail> listOrderDetails = ordersManager.CheckOutValidation(idOrder);

            if (listOrderDetails == null)
            {
                return Json(new { code = 444, msg = "failure" });
            }
            else return Json(new { code = 666, msg = "successfuly" });
        }



    }
}
