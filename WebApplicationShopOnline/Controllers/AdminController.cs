using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class AdminController : Controller
    {
        readonly IProductsRepository productsRepository;

        public AdminController(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        [HttpGet]
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
                ModelState.AddModelError("Name", "Слишком короткое имя");
            }

            if (ModelState.IsValid)
            {
                productsRepository.Add(product);
                return RedirectToAction("Products", "Admin");
            }
            else
            {
                return View(product);
            }
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            var product = productsRepository.TryGetById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(ProductEdit product)
        {
            productsRepository.Updata(product);
            return RedirectToAction("Index", "Product", product.Id);
        }

    }
}
