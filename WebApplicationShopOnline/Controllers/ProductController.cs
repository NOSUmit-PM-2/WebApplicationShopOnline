using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using OnlineShop.DB;
using System.Diagnostics;
using System.Xml.Linq;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Helpers;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductDBsRepository productsRepository;

        public ProductController(IProductDBsRepository prodRepo)
        {
            this.productsRepository = prodRepo;
        }

                public IActionResult Index(int id)
        {
            Product product = catalog.TryGetById(id);
            if (product != null) 
                  return View(product);
            return null;
        }

        public IActionResult Catalog()
        {
            var products = catalog.GetProducts();
            return View(products);
        }

        
    }
}