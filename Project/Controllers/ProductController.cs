using Microsoft.AspNetCore.Mvc;
using Project.Data;
using Project.Models;
namespace Project.Controllers
{
    public class ProductController : Controller
    {
        public ProductController()
        {
            DataSource data = new DataSource();
        }
        public IActionResult Index()
        {
            List<Product> products = DataSource.Products;
            List<Category> categories = DataSource.Categories;
            
            foreach (var product in products)
            {
                product.Category = categories.FirstOrDefault(c => c.Id == product.CategoryId);
            }
            return View(products);
        }

        public IActionResult Details(int id)
        {
            Product product = DataSource.Products.FirstOrDefault(p => p.Id == id);
            Category category = DataSource.Categories.FirstOrDefault(c => c.Id == product.CategoryId);
            product.Category = category;
            return View(product);
        }

        public IActionResult Create()
        {
            List<Category> categories = DataSource.Categories;
            ViewBag.Categories = categories;
            return View();
        }
    }

}
