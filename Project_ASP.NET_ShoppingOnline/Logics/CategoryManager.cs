using Project_ASP.NET_ShoppingOnline.Models;
using System.Collections.Generic;
using System.Linq;
namespace Project_ASP.NET_ShoppingOnline.Logics
{
    public class CategoryManager
    {
        WebshopContext context;

        public CategoryManager()
        {
            context = new WebshopContext();
        }
        public List<Category> GetAllCategories()
        {
            return context.Categories.ToList();
        }
    }
}
