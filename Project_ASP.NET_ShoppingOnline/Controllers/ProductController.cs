using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_ASP.NET_ShoppingOnline.Fiter;
using Project_ASP.NET_ShoppingOnline.Logics;
using Project_ASP.NET_ShoppingOnline.Models;
using System.Collections.Generic;
using System.IO;
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
        [TypeFilter(typeof(fitercustom))]

        public IActionResult ListProductManager(int page = 1)
        {
            ProductManager productManager = new ProductManager();
            
            List<Product> listP = productManager.GetProductsByCategoryId(0);

            const int PageSize = 8;
            var count = listP.Count();
            var data = listP.Skip((page - 1) * PageSize).Take(PageSize).ToList();
            ViewBag.MaxPage = (count / PageSize) - (count % PageSize == 0 ? 1 : 0);
            ViewBag.Page = page;
            return View(data);
        }

        [TypeFilter(typeof(fitercustom))]

        public IActionResult addNewProduct(Product p = null)
        {
            ProductManager productManager = new ProductManager();

            int nextId = productManager.getNewIdProduct() + 1;
            ViewBag.nextPid = nextId;
            CategoryManager categoryManager = new CategoryManager();
            List<Category> listCa = categoryManager.GetAllCategories();
            ViewBag.listCa = listCa;

            Product product = categoryManager.GetAllCategoriesProduct(p);
            return View(product);
        }
        [TypeFilter(typeof(fitercustom))]
        [HttpPost]
        public IActionResult doAddNewProduct(string name = null,int price = 0,int inStock = 0,string description = null,IFormFile myfile =null , int cid = 0)
        {
            if( name == null || price == 0 || inStock == 0)
            {
                ViewBag.Mess = "Vui lòng kiểm tra lại thông tin!";

               
                
                CategoryManager categoryManager = new CategoryManager();
                List<Category> listCa = categoryManager.GetAllCategories();
                ViewBag.listCa = listCa;
                return View("~/Views/Product/addNewProduct.cshtml");
            }
            else
            {
                ProductManager productManager = new ProductManager();
                Product p = new Product();
                
                if (myfile != null)
                {
                    //chỉ định đường dẫn sẽ lưu
                    string fullPath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot", "images", myfile.FileName);
                    //copy file vào thư mục chỉ định
                    using (var file = new FileStream(fullPath, FileMode.Create))
                    {
                        myfile.CopyTo(file);
                    }

                }

                p.ProductName = name;
                p.UnitPrice = price;
                p.UnitsInStock = inStock;
                p.Description = description;
                p.CategoryId = cid;
                p.Status = true;
                p.Image = (myfile != null) ? "images/"+myfile.FileName : "";
                
                
                ViewBag.Mess = "Thêm thành công 1 sản phẩm!";
                productManager.addNewProduct(p);
                
                
                CategoryManager categoryManager = new CategoryManager();
                List<Category> listCa = categoryManager.GetAllCategories();
                ViewBag.listCa = listCa;
                
                
                return RedirectToAction("addNewProduct", "Product",p);
            }
            

            
        }

        [TypeFilter(typeof(fitercustom))]
        public RedirectResult deleteProduct(int id)
        {
            
            ProductManager productManager = new ProductManager();
            Product ePro = productManager.GetProductById(id);
            productManager.deleteProduct(ePro);
            return Redirect("/Product/ListProductManager/" + 1);

        }
        [TypeFilter(typeof(fitercustom))]
        public IActionResult editProduct(int id,Product p = null)
        {
            CategoryManager categoryManager = new CategoryManager();
            List<Category> listCa = categoryManager.GetAllCategories();
            ViewBag.listCa = listCa;

            ProductManager productManager = new ProductManager();

            Product ePro = productManager.GetProductById(id);
            ViewBag.ePro = ePro;


            Product product = categoryManager.GetAllCategoriesProduct(p);

            return View(product);
        }
        [TypeFilter(typeof(fitercustom))]
        [HttpPost]
        public IActionResult doeditProduct(int id, string name = null, int price = 0, int inStock = 0, string description = null, IFormFile myfile = null, int cid = 0)
        {
            if (name == null || price == 0 || inStock == 0)
            {
                ViewBag.Mess = "Vui lòng kiểm tra lại thông tin!";
                ProductManager productManager = new ProductManager();
                Product ePro = productManager.GetProductById(id);
                ViewBag.ePro = ePro;

                CategoryManager categoryManager = new CategoryManager();
                List<Category> listCa = categoryManager.GetAllCategories();
                ViewBag.listCa = listCa;
                //datatype:RedirectResult return Redirect("/Product/editProduct/"+id);
                return View("~/Views/Product/editProduct.cshtml");
            }
            else
            {
                ProductManager productManager = new ProductManager();
                Product p = new Product();

                if (myfile != null)
                {
                    //chỉ định đường dẫn sẽ lưu
                    string fullPath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot", "images", myfile.FileName);
                    //copy file vào thư mục chỉ định
                    using (var file = new FileStream(fullPath, FileMode.Create))
                    {
                        myfile.CopyTo(file);
                    }
                    p.Image = "images/" + myfile.FileName;
                }
                p.ProductId = id;
                p.ProductName = name;
                p.UnitPrice = price;
                p.UnitsInStock = inStock;
                p.Description = description;
                p.CategoryId = cid;
                p.Status = true;               


                ViewBag.Mess = "Update thành công 1 sản phẩm!";
                productManager.EditProduct(p);

                Product ePro = productManager.GetProductById(id);
                ViewBag.ePro = ePro;
                CategoryManager categoryManager = new CategoryManager();
                List<Category> listCa = categoryManager.GetAllCategories();
                ViewBag.listCa = listCa;

                return RedirectToAction("editProduct", "Product",new {id=id,p=p});
                //return Redirect("/Product/editProduct/"+id);
            }



        }





    }
}
