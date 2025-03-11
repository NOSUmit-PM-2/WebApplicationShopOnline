using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository catalog = new ProductRepository();

        public IActionResult Index(string name, decimal cost, string description)
        {

            Product product = catalog.TryGetById(1);
            if (product != null) 
                  return View(product);
            return null;
        }

        public IActionResult Catalog()
        {
            var products = catalog.GetProducts();
            //return View("CatalogSimple", products);
            return View(products);
        }
    }
}
