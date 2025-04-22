using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public class ProductsInMemoryRepository : IProductsRepository
    {

        static List<Product> products = new List<Product>()
        {
            new Product("Чебурек", "с сыром", 120, ""),
            new Product("Пирожок", "с картошкой", 50, ""),
            new Product("Шаурма","клаcсическая", 400, "")
        };

        public List<Product> GetAll()
        {
            return products;
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public Product TryGetById(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }
    }
}
