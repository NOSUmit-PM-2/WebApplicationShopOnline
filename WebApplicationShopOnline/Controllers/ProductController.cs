using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductsRepository productsRepository;

        public ProductController(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public IActionResult Index(int id)
        {
            Product prod = productsRepository.TryGetById(id);
            //ViewBag.Product = prod;
            return View(prod);
        }


        public IActionResult Catalog(int id)
        {
            List<Product>products = productsRepository.GetAll();
            return View(products);
        }

    }
}
