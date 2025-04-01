using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public interface ICartsRepository
    {
        Cart TryGetByUserId(int id);
        void Add(Product product, int userId);
    }
}
