using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public class CartsInMemoryRepository : ICartsRepository
    {
        static List<Cart> carts = new List<Cart>();
        public Cart TryGetByUserId(int id)
        {
            return carts.FirstOrDefault(x => x.UserId == id);
        }
        public void Add(Product product, int userId)
        {
            var currentCart = TryGetByUserId(userId);
            if (currentCart == null)
            {
                var newCart = new Cart();
                newCart.Id = Guid.NewGuid();
                newCart.UserId = userId;
                newCart.Items = new List<CartItem>();
                newCart.Items.Add(AddItem(product));
                carts.Add(newCart);
            }
            else
            {
                var existingItem = currentCart.Items.FirstOrDefault(x => x.Product.Id == product.Id);
                if (existingItem == null)
                {
                    currentCart.Items.Add(AddItem(product));
                }
                else
                {
                    existingItem.Amount++;
                }
            }
        }
        private CartItem AddItem(Product product)
        {
            CartItem item = new CartItem();
            item.Id = Guid.NewGuid();
            item.Product = product;
            item.Amount = 1;
            return item;
        }
    }
}
