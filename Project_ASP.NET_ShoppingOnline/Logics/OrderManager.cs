using Project_ASP.NET_ShoppingOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_ASP.NET_ShoppingOnline.Logics
{
    public class OrderManager
    {
        WebshopContext context;
        public OrderManager()
        {
            context = new WebshopContext();
        }
        public void AddToCart(int idP, Customer cus)
        {
            ProductManager productManager = new ProductManager();
            Product p = productManager.GetProductById(idP);
          //  string customerID = cus.CustomerId;

            if (!checkOrderExist(cus.CustomerId))//nếu chưa có order nào thì thêm mới
            {
                Order order = new Order();
                order.CustomerId = cus.CustomerId;
                order.Expired = true;
                context.Orders.Add(order);
                context.SaveChanges();
            }



            //lay id cua orders vua add
            int idOrder = context.Orders
                .Where(x => x.CustomerId == cus.CustomerId && x.Expired == true)
                .Select(x => x.OrderId).FirstOrDefault();
            //add product to orderdetail
            OrdersDetail orderDetail = new OrdersDetail();
            orderDetail.OrderId = idOrder;
            orderDetail.ProductId = p.ProductId;
            orderDetail.UnitPrice = p.UnitPrice;

            if (checkOrderDetailExist(idOrder, idP))//nếu OrderDetail tồn tại product thì update quantity
            {
                OrdersDetail orderDetailOld = context.OrdersDetails.Where(x => x.OrderId == idOrder && x.ProductId == idP).FirstOrDefault();
                orderDetailOld.Quantity = (short)(orderDetailOld.Quantity + 1);

                context.OrdersDetails.Update(orderDetailOld);
                context.SaveChanges();
            }
            else
            {
                orderDetail.Quantity = 1;
                context.OrdersDetails.Add(orderDetail);
                context.SaveChanges();
            }

            //  context.SaveChanges();


        }

        public List<OrdersDetail> getOrderDetail(int Odid)
        {
            context.Products.ToList();
            List<OrdersDetail> orderDetail = context.OrdersDetails.Where(x => x.OrderId == Odid).ToList();
            return orderDetail;
        }

        public bool checkOrderExist(int Cusid)
        {
            Order order = context.Orders.Where(x => x.CustomerId == Cusid && x.Expired == true).FirstOrDefault();
            if (order == null) return false;
            else return true;
        }

        internal int SetNumberQuantity(int idOrder, int idP, int status)
        {
            int quantityP = (int)context.Products.Where(x => x.ProductId == idP).Select(x => x.UnitsInStock).FirstOrDefault();

            if (status == 0)// -
            {
                OrdersDetail orderDetailOld = context.OrdersDetails.Where(x => x.OrderId == idOrder && x.ProductId == idP).FirstOrDefault();
                if (orderDetailOld.Quantity > 1)
                {
                    orderDetailOld.Quantity = (short)(orderDetailOld.Quantity - 1);

                    context.OrdersDetails.Update(orderDetailOld);
                    context.SaveChanges();
                }

            }

            if (status == 1)// +
            {
                OrdersDetail orderDetailOld = context.OrdersDetails.Where(x => x.OrderId == idOrder && x.ProductId == idP).FirstOrDefault();
                if (orderDetailOld.Quantity < quantityP)
                {
                    orderDetailOld.Quantity = (short)(orderDetailOld.Quantity + 1);

                    context.OrdersDetails.Update(orderDetailOld);
                    context.SaveChanges();
                }

            }

            return context.OrdersDetails.Where(x => x.OrderId == idOrder && x.ProductId == idP).Select(x => x.Quantity).FirstOrDefault();
        }

        public bool checkOrderDetailExist(int Oid, int pid)
        {
            OrdersDetail orderDetail = context.OrdersDetails.Where(x => x.OrderId == Oid && x.ProductId == pid).FirstOrDefault();
            if (orderDetail == null) return false;
            else return true;
        }

        internal void DeleteItem(int idOrder, int idP)
        {
            OrdersDetail orderDetailOld = context.OrdersDetails.Where(x => x.OrderId == idOrder && x.ProductId == idP).FirstOrDefault();
            context.OrdersDetails.Remove(orderDetailOld);
            context.SaveChanges();
        }

        internal Order getOrder(Customer cus)
        {
            Order order = context.Orders.Where(x => x.CustomerId == cus.CustomerId && x.Expired == true).FirstOrDefault();
            if (order == null) return null;
            else return order;
        }

        internal List<OrdersDetail> CheckOut(int idOrder,int bill)
        {
            Order order = new Order();
            order = context.Orders.Where(x => x.OrderId == idOrder && x.Expired == true).FirstOrDefault();
            order.Expired = false;
            order.Totalmoney = bill;
            context.Orders.Update(order);

            context.Products.ToList();
            List<OrdersDetail> orderDetail = context.OrdersDetails.Where(x => x.OrderId == idOrder).ToList();

            bool check = true;
            foreach (OrdersDetail odDetail in orderDetail)
            {
                Product product = new Product();
                product = context.Products.Where(x => x.ProductId == odDetail.ProductId).FirstOrDefault();
                if (product.UnitsInStock - odDetail.Quantity >= 0)
                {
                    product.UnitsInStock -= odDetail.Quantity;
                    context.Products.Update(product);
                    context.SaveChanges();
                }
                else
                {
                    check = false;
                }

            }
            if (check)
            {
                return orderDetail;
            }
            else
            {
                return null;
            }
        }

        internal int getSizeOfCart(Customer cus)
        {
            
            int idOrder = context.Orders
                .Where(x => x.CustomerId == cus.CustomerId && x.Expired == true)
                .Select(x => x.OrderId).FirstOrDefault();
            int size = context.OrdersDetails.Where(x => x.OrderId == idOrder).Count();
            return size;
        }

        internal List<OrdersDetail> CheckOutValidation(int idOrder)
        {
            
            Order order = new Order();
            order = context.Orders.Where(x => x.OrderId == idOrder && x.Expired == true).FirstOrDefault();
            //order ở đây có thể null bởi vì việc lấy idOrder là từ thẻ input trong body table,nếu k có sp nào thì k có body table => k in ra ipnut => id null


            context.Products.ToList();
            List<OrdersDetail> orderDetail = context.OrdersDetails.Where(x => x.OrderId == idOrder).ToList();

            bool check = true;
            foreach (OrdersDetail odDetail in orderDetail)
            {
                Product product = new Product();
                product = context.Products.Where(x => x.ProductId == odDetail.ProductId).FirstOrDefault();
                if (product.UnitsInStock - odDetail.Quantity >= 0)
                {
                    product.UnitsInStock -= odDetail.Quantity;

                }
                else
                {
                    check = false;
                }

            }
            if (check && order != null)
            {
                return orderDetail;
            }
            else
            {
                return null;
            }
        }
    }
}
