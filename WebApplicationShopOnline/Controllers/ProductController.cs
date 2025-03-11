using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Xml.Linq;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }



        public IActionResult Index(string name, string description, decimal cost, string path)
        {
            Product prod = new Product(name, description, cost, path);
            return View(prod);
        }
        
       
    }
}