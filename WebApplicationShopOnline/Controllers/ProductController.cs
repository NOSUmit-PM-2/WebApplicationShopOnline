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
        readonly IProductsRepository productsRepository;

        public ProductController(IProductsRepository prodRepo)
        {
            this.productsRepository = prodRepo;
        }

        public IActionResult Index(int id)
        {
            Product prod = productsRepository.TryGetById(id);
            return View(prod);
        }


        public IActionResult Catalog() 
        {
            List<Product>products = productsRepository.GetAll();
            //return View("CatalogSimple", products);
            return View(products);
        }
    }
}