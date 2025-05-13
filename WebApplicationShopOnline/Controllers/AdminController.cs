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
            if (product.Name.Length < 3)
            {
                ModelState.AddModelError("Name", "Слишком короткое название");
            }
            if (ModelState.IsValid)
            {
                productsRepository.Add(product);
                return RedirectToAction("Products", "Admin");
            }
            return View(product);
        }
        public IActionResult EditProduct(int id)
        {
            var product = productsRepository.TryGetById(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            if (product.Name.Length < 3)
            {
                ModelState.AddModelError("Name", "Слишком короткое название");
            }
            if (ModelState.IsValid)
            {
                productsRepository.Update(product);
                return RedirectToAction("Index", "Product", new { id = product.Id });
            }
            return View(product);
        }
    }
}