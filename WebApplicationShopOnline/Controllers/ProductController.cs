using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Xml.Linq;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class ProductController : Controller
    {
        ProductsRepository productsRepository = new ProductsRepository();
        
        private readonly ILogger<ProductController> _logger;


        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index(int id)
        {
            Product prod = productsRepository.TryGetById(id);
            return View(prod);
        }


        public IActionResult Catalog(int id) 
        {
            List<Product>products = productsRepository.GetAll();
            //return View("CatalogSimple", products);
            return View(products);
        }
    }
}