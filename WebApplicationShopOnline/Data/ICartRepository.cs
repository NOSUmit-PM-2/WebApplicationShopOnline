using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public interface ICartRepository
    {
        Cart TryGetByUserId(int id);
        void Add(Product product, int userId);
        void IncreaseCountProduct(int productId, int userId);
        void DecreaseCountProduct(int productId, int v);
    }
}
