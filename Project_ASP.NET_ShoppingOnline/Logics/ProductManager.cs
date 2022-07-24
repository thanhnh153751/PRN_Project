using Newtonsoft.Json;
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
            return context.Products.Where(x => x.Status.Value == true).OrderByDescending(x => x.ProductId).Take(4).ToList();
        }

        internal Product GetProductById(int idP)
        {
            context.Categories.ToList();
            return context.Products.Where(x => x.ProductId == idP && x.Status.Value == true).FirstOrDefault();
        }

        public List<Product> GetBestSellerProducts()
        {
            List<Product> products = new List<Product>();

            return context.Products.OrderByDescending(x => x.ProductId).Take(4).ToList();
        }

        public dynamic GetTopViewProducts()
        {
            var resou = context.Products
                .Join(
                    context.ViewProducts,
                    pro => pro.ProductId,
                    vie => vie.ProductId,
                    (pro, vie) => new { Pro = pro, Vie = vie, X = vie.View }
                )
                .GroupBy(
                    x => new
                    {
                        x.Pro.ProductId,
                        x.Vie.Viewdate.Value.Year,
                        x.Vie.Viewdate.Value.Month
                    }
                )
                .Select(
                    y => new
                    {
                        ProductId = y.Key.ProductId,
                        Year = y.Key.Year,
                        Month = y.Key.Month,
                        Total = y.Sum(x => x.Vie.View)
                    }
                )
                .Join(
                    context.Products,
                    vie => vie.ProductId,
                    pro => pro.ProductId,
                    (vie, pro) => new { Pro = pro, Vie = vie }
                )
                .OrderByDescending(x => x.Vie.Year)
                .ThenByDescending(x => x.Vie.Month)
                .ThenByDescending(x => x.Vie.Total)
                .Take(4);
            return resou;
        }

        public List<Product> GetProductsByCategoryId(int id)
        {
            if (id == 0)
            {
                context.Categories.ToList();
                return context.Products.Where(x=>x.Status.Value==true).ToList();
            }
            else return context.Products.Where(x => x.CategoryId == id && x.Status.Value == true).ToList();
        }

        public List<Product> GetProductsBySeachBox(string key)
        {
            if (key.Equals(string.Empty)) return context.Products.ToList();
            else return context.Products.Where(x => x.ProductName.Contains(key) || x.Category.CategoryName.Contains(key)).ToList();
        }

        public List<Product> getProductByFiter(int[] cid, string[] color,int rangePriceFrom, int rangePriceTo, int orderByPrice)
        {
            //List<int> ids = new List<int>();
            //foreach(int id in cid)
            //{
            //    ids.Add(id);
            //}
            var resou = context.Products.Where(x => cid.Contains(x.CategoryId) && x.Status.Value == true).ToList();
            return null;
        }

        public void addNewProduct(Product p)
        {
            context.Categories.ToList();
            context.Products.Add(p);
            context.SaveChanges();
        }

        public void EditProduct(Product p)
        {
            context.Categories.ToList();
            context.Products.Update(p);
            context.SaveChanges();
        }

        public int getNewIdProduct()
        {
            return context.Products.Select(x => x.ProductId).Max();
        }

        public void deleteProduct(Product p)
        {
            p.Status = false;
            context.Products.Update(p);
            context.SaveChanges();
        }


    }
}
