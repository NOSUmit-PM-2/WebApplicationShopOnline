using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;
namespace WebApplicationShopOnline.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository productReposiitory = new ProductRepository();
        public IActionResult Index()
        {
            Product prod = new Product("пирожок", "с вишней", 50);
            return View(prod);
        }
        public IActionResult Catalog(int id)
        {
            List<Product> products = productReposiitory.GetAll();
            return View(products);
        }
    }
}
