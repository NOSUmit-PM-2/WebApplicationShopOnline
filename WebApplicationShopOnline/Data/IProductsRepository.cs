using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public interface IProductsRepository
    {
        List<Product> GetProducts();
        Product TryGetById(int id);
        List<Product> GetAll();
        void Add(Product product);
    }
}