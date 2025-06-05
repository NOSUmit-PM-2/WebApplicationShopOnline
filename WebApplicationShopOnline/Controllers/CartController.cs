using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using System.Linq;

namespace OnlineShop.Controllers
{
    public class CartController : Controller
    {
        private readonly CartDBRepository _cartRepository;

        public CartController(CartDBRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        // Главная страница - список товаров в корзине
        public IActionResult Index()
        {
            var items = _cartRepository.GetAllItems();
            return View(items);
        }

        // Изменение количества товара
        [HttpPost]
        public IActionResult Update(int id, int quantity)
        {
            _cartRepository.UpdateItem(id, quantity);
            return RedirectToAction("Index");
        }

        // Удаление товара
        public IActionResult Delete(int id)
        {
            _cartRepository.DeleteItem(id);
            return RedirectToAction("Index");
        }
    }
}
