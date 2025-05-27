using Microsoft.AspNetCore.Mvc;
using OnlineShop.DB;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class AdminController : Controller
    {
        readonly IProductDBsRepository productsRepository;

        public AdminController(IProductDBsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        [HttpGet]
        public IActionResult Products(int id)
        {
            return View(Mapping.ToProductList(productsRepository.GetAll()));
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
                productsRepository.Add(Mapping.ToProductDB(product));
                return RedirectToAction("Products", "Admin");
            }
            else
            {
                return View(product);
            }
        }

        [HttpGet]
        public IActionResult EditProduct(Guid id)
        {
            ProductDB product = productsRepository.TryGetById(id);
            return View(Mapping.ToProduct(product));
        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            productsRepository.Updata(Mapping.ToProductDB(product));
            return RedirectToAction("Index", "Product", product.Id);
        }

    }
}
