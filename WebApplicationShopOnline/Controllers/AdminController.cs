using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Xml.Linq;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class AdminController : Controller
    {
        readonly IProductsRepository productsRepository;

        public AdminController(IProductsRepository prodRepo)
        {
            this.productsRepository = prodRepo;
        }


        public IActionResult Products(int id)
        {
            return View(productsRepository.GetAll());
        }


        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            productsRepository.Add(product);
            return RedirectToAction("Products", "Admin");
        }
    }
}