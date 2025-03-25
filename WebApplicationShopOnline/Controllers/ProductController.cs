using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductRepository productsRepository;

        public ProductController(IProductRepository prodRepo)
        {
            this.productsRepository = prodRepo;
        }

        public IActionResult Index(int id)
        {
            Product product = productsRepository.TryGetById(id);
            return View(product);
        }

        public IActionResult Catalog()
        {
            var products = productsRepository.GetProducts();
            //return View("CatalogSimple", products);
            return View(products);
        }
    }
}
