using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public interface ICartsRepository
    {
        Cart TryGetByUserId(int id);
        void Add(Product product, int userId);
        void IncreaseCount(int productId, int userId);
        void DecreaseCount(int productId, int userId);
    }
}
