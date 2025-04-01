using WebApplicationShopOnline.Models;
using System.Text.Json;

namespace WebApplicationShopOnline.Data
{
    public class ProductInJSONRepository : IProductRepository
    {
        private static List<Product> products;

        public ProductInJSONRepository()
        {
            var jsonString = File.ReadAllText("Data/products.json");
            products = JsonSerializer.Deserialize<List<Product>>(jsonString);
        }

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
