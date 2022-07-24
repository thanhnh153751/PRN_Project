using Project_ASP.NET_ShoppingOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Project_ASP.NET_ShoppingOnline.Logics
{
    public class CustomerManager
    {
        WebshopContext context;

        public CustomerManager()
        {
            context = new WebshopContext();
        }
        public Customer GetCustommerLogin(string user,string pass)
        {
            Customer customer = new Customer();
            customer = context.Customers.Where(x => x.Username.Equals(user) && x.Password.Equals(pass)).FirstOrDefault();           
            return customer;
        }
        public List<Customer> getListCustomManager()
        {                        
            return context.Customers.ToList();
        }

        public List<OrdersDetail> getListOrdersDetail()
        {
            context.Products.ToList();
            return context.OrdersDetails.ToList();
        }

        public List<Order> getListOrderCustomByCusId(int id)
        {
            context.OrdersDetails.ToList();
            return context.Orders.Where(x => x.CustomerId == id && x.Expired.Value == false ).ToList();
        }

    }
}
