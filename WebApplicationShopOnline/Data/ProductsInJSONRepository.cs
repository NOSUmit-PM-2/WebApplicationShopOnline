using WebApplicationShopOnline.Models;
using System.Text.Json;

namespace WebApplicationShopOnline.Data
{
    public class ProductsInJSONRepository : IProductsRepository
    {

        List<Product> products;

        public ProductsInJSONRepository()
        {
            var jsonString = File.ReadAllText("Data/products.json");
            products = JsonSerializer.Deserialize<List<Product>>(jsonString);
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product TryGetById(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }
    }
}
