
namespace OnlineShop.DB
{
    public interface ICartDBsRepository
    {
        CartDB TryGetByUserId(int id);
        void Add(ProductDB product, int userId);
        void IncreaseCountProduct(Guid productId, int userId);
        void DecreaseCountProduct(Guid productId, int userId);
    }
}