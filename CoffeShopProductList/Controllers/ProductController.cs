using CoffeShopProductList.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeShopProductList.Controllers
{
    public class ProductController : Controller
    {
        public CoffeeProductDbContext context = new CoffeeProductDbContext();
        public IActionResult Index()
        {
            return View(context.Products.ToList());
        }
        public IActionResult Details(int productId)
        {
            Product p = context.Products.FirstOrDefault(p => p.Id == productId);
            return View(p);
        }
        public IActionResult Products()
        {
            List<Product> products = context.Products.ToList();
            return View(products);
        }

    }
}
