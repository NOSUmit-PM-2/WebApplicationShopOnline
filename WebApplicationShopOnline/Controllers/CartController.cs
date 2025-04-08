using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class CartController : Controller
    {
        readonly ICartsRepository cartsRepository;
        readonly IProductRepository productsRepository;

        public CartController(ICartsRepository cartsRepository, IProductRepository productsRepository)
        {
            this.cartsRepository = cartsRepository;
            this.productsRepository = productsRepository;
        }
        public IActionResult Index(int id)
        {
            Cart cart = cartsRepository.TryGetByUserId(1);
            return View(cart);
        }
        public IActionResult Add(int id)
        {
            Product product = productsRepository.TryGetById(id);
            cartsRepository.Add(product, 1);
            return RedirectToAction("Index");
        }
        public IActionResult IncreaseCount(int id)
        {
            cartsRepository.IncreaseCount(id, 1);
            return RedirectToAction("Index");
        }
        public IActionResult DecreaseCount(int id)
        {
            cartsRepository.DecreaseCount(id, 1);
            return RedirectToAction("Index");
        }
    }
}
