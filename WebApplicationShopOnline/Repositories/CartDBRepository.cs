using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationShopOnline.Data;

namespace WebApplicationShopOnline.Models.Repositories
{
    public class CartDBRepository : ICartRepository
    {
        private readonly ApplicationDbContext _context;

        public CartDBRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Cart> GetCartAsync(int userId)
        {
            var cart = await _context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null)
            {
                cart = new Cart
                {
                    UserId = userId,
                    CreatedAt = DateTime.Now,
                    CartItems = new List<CartItem>()
                };
                _context.Carts.Add(cart);
                await _context.SaveChangesAsync();
            }

            return cart;
        }

        public async Task<CartItem> GetCartItemAsync(int cartItemId)
        {
            return await _context.CartItems.FindAsync(cartItemId);
        }

        public async Task<IEnumerable<CartItem>> GetCartItemsAsync(int cartId)
        {
            return await _context.CartItems
                .Where(ci => ci.CartId == cartId)
                .ToListAsync();
        }

        public async Task AddItemToCartAsync(int userId, int productId, string productName, decimal price, int quantity)
        {
            var cart = await GetCartAsync(userId);
            var existingItem = cart.CartItems.FirstOrDefault(item => item.ProductId == productId);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
                _context.CartItems.Update(existingItem);
            }
            else
            {
                var newItem = new CartItem
                {
                    CartId = cart.CartId,
                    ProductId = productId,
                    ProductName = productName,
                    Price = price,
                    Quantity = quantity
                };
                _context.CartItems.Add(newItem);
            }

            await _context.SaveChangesAsync();
        }

        public async Task UpdateCartItemQuantityAsync(int cartItemId, int quantity)
        {
            var cartItem = await GetCartItemAsync(cartItemId);
            if (cartItem != null)
            {
                cartItem.Quantity = quantity;
                _context.CartItems.Update(cartItem);
                await _context.SaveChangesAsync();
            }
        }

        public async Task RemoveCartItemAsync(int cartItemId)
        {
            var cartItem = await GetCartItemAsync(cartItemId);
            if (cartItem != null)
            {
                _context.CartItems.Remove(cartItem);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<int> GetCartItemsCountAsync(int userId)
        {
            var cart = await GetCartAsync(userId);
            return cart.CartItems.Sum(item => item.Quantity);
        }
    }
}

