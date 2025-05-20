using Microsoft.AspNetCore.Mvc;
using OnlineShop.DB;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductDBsRepository productsRepository;

        public ProductController(IProductDBsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public IActionResult Index(Guid id)
        {
            ProductDB prod = productsRepository.TryGetById(id);
            //ViewBag.Product = prod;
            return View(prod);
        }


        public IActionResult Catalog()
        {
            List<ProductDB> products = productsRepository.GetAll();
            return View();
        }

    }
}
