using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplicationShopOnline.Models.Repositories;

namespace WebApplicationShopOnline.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartRepository _cartRepository;

        public CartController(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task<IActionResult> Index()
        {
            // Временно используем userId = 1, в реальном приложении нужно брать из системы аутентификации
            var cart = await _cartRepository.GetCartAsync(1);
            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQuantity(int cartItemId, int quantity)
        {
            if (quantity > 0)
            {
                await _cartRepository.UpdateCartItemQuantityAsync(cartItemId, quantity);
            }
            else
            {
                await _cartRepository.RemoveCartItemAsync(cartItemId);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> RemoveItem(int cartItemId)
        {
            await _cartRepository.RemoveCartItemAsync(cartItemId);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId, string productName, decimal price, int quantity = 1)
        {
            // Временно используем userId = 1
            await _cartRepository.AddItemToCartAsync(1, productId, productName, price, quantity);
            return RedirectToAction(nameof(Index));
        }
    }
}