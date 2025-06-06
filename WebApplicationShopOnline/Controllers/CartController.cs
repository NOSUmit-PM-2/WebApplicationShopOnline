using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Xml.Linq;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;
using System.Threading.Tasks;
using WebApplicationShopOnline.Models.Repositories;

namespace WebApplicationShopOnline.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartRepository ccartRepository;

        public CartController(ICartRepository cartRepository)
        {
            ccartRepository = cartRepository;
        }

        public async Task<IActionResult> Index()
        {
            var cart = await ccartRepository.GetCartAsync(1);
            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQuantity(int cartItemId, int quantity)
        {
            if (quantity > 0)
            {
                await ccartRepository.UpdateCartItemQuantityAsync(cartItemId, quantity);
            }
            else
            {
                await ccartRepository.RemoveCartItemAsync(cartItemId);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> RemoveItem(int cartItemId)
        {
            await ccartRepository.RemoveCartItemAsync(cartItemId);
            return RedirectToAction(nameof(Index));
        }                
    }
}