using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplicationShopOnline.Models.Repositories
{
    public interface ICartRepository
    {
        Task<Cart> GetCartAsync(int userId);
        Task<CartItem> GetCartItemAsync(int cartItemId);
        Task<IEnumerable<CartItem>> GetCartItemsAsync(int cartId);
        Task AddItemToCartAsync(int userId, int productId, string productName, decimal price, int quantity);
        Task UpdateCartItemQuantityAsync(int cartItemId, int quantity);
        Task RemoveCartItemAsync(int cartItemId);
        Task<int> GetCartItemsCountAsync(int userId);
    }
}
