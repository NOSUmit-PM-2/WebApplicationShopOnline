using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class CartController : Controller
    {
        readonly IProductsRepository productsRepository;
        readonly ICartRepository cartsRepository;

        public CartController(IProductsRepository productsRepository, ICartRepository cartsRepository)
        {
            this.productsRepository = productsRepository;
            this.cartsRepository = cartsRepository;
        }

        public IActionResult Index(int id)
        {
            Cart cart = cartsRepository.TryGetByUserId(1);
            return View(cart);
        }
        public IActionResult Add(Guid id)
        {
            Product product = productsRepository.TryGetById(id);
            cartsRepository.Add(product, 1);
            return RedirectToAction("Index");
        }

        public IActionResult IncreaseCountProduct(Guid productId)
        {
            cartsRepository.IncreaseCountProduct(productId, 1);
            return RedirectToAction("Index");
        }

        public IActionResult DecreaseCountProduct(Guid productId)
        {
            cartsRepository.DecreaseCountProduct(productId, 1);
            return RedirectToAction("Index");
        }

    }
}
