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
    }
}
