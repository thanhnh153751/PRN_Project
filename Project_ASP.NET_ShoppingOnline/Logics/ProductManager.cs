using Project_ASP.NET_ShoppingOnline.Models;
using System.Collections.Generic;
using System.Linq;
namespace Project_ASP.NET_ShoppingOnline.Logics
{
    public class ProductManager
    {
        WebshopContext context;

        public ProductManager()
        {
            context = new WebshopContext();
        }
        public List<Product> GetNewsProducts()
        {
            return context.Products.OrderByDescending(x => x.ProductId).Take(4).ToList();
        }
        public List<Product> GetProductsByCategoryId(int id)
        {
            if(id == 0) return context.Products.ToList();
            else return context.Products.Where(x => x.CategoryId == id).ToList();
        }
    }
}
