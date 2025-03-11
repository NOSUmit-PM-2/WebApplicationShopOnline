using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public class ProductRepository
    {
        private static List<Product> products = new List<Product>()
        {
            new Product("Чебурек", "с сыром", 120),
            new Product("Пирожок", "печеный", 50),
            new Product("Шаурма", "детская", 320)
        };

        public List<Product> GetProducts()
        { 
            return products;
        }

        public Product TryGetById(int id) 
        {
            return products.FirstOrDefault(product => product.Id == id);
        }
    

    }
}
