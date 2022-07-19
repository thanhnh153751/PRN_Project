using Project_ASP.NET_ShoppingOnline.Models;
using System;
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

        public List<Product> GetBestSellerProducts()
        {
            List<Product> products = new List<Product>();

            return context.Products.OrderByDescending(x => x.ProductId).Take(4).ToList();
        }

        public List<Product> GetTopViewProducts()
        {
            return context.Products
                .Join(
                context.ViewProducts,
                pro => pro.ProductId,
                vie => vie.ProductId,
                (pro, vie) => new { Pro = pro, Vie = vie })
                .GroupBy(x => new { x.Vie.Viewdate.Value.Year, x.Vie.Viewdate.Value.Month, x.Pro })
                .SelectMany(x => x.Select(x => x.Pro)).ToList();
        }

        public List<Product> GetProductsByCategoryId(int id)
        {
            if(id == 0) return context.Products.ToList();
            else return context.Products.Where(x => x.CategoryId == id).ToList();
        }

        public List<Product> getProductByFiter(int[] cid, string[] color,int rangePrice,int orderByPrice)
        {
            return null;
        }


    }
}
