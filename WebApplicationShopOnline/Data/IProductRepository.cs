using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product TryGetById(int id);
    }
}