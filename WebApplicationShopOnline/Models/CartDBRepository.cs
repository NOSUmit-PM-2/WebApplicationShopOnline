using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Models
{
    public class CartDBRepository
    {
        private readonly ApplicationDbContext _context;

        public CartDBRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Получить все товары из корзины
        public IEnumerable<CartItem> GetAllItems()
        {
            return _context.CartItems.ToList();
        }

        // Добавить товар в корзину
        public void AddItem(CartItem item)
        {
            _context.CartItems.Add(item);
            _context.SaveChanges();
        }

        // Обновить количество товара
        public void UpdateItem(int id, int quantity)
        {
            var item = _context.CartItems.Find(id);
            if (item != null)
            {
                item.Quantity = quantity;
                _context.SaveChanges();
            }
        }

        // Удалить товар из корзины
        public void DeleteItem(int id)
        {
            var item = _context.CartItems.Find(id);
            if (item != null)
            {
                _context.CartItems.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}
