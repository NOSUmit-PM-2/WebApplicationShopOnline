using WebApplicationShopOnline.Models;
using System.Text.Json;
using System.Text.Encodings.Web;

namespace WebApplicationShopOnline.Data
{
    public class ProductInJSONRepository : IProductsRepository
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

        public List<Product> GetAll()
        {
            return products;
        }

        public void Add(Product product)
        {
            products.Add(product);
            Save();
        }
        public void Update(Product product)
        {
            var existingProduct = products.FirstOrDefault
      (x => x.Id == product.Id);
            if (existingProduct == null)
            {
                return;
            }
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Cost = product.Cost;
            existingProduct.PathImage = product.PathImage;
            Save();
        }

        private void Save()
        {
            string updatedJsonString = JsonSerializer.Serialize(products,
            new JsonSerializerOptions
            {
                WriteIndented = true, // человекочитаемый формат
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
            File.WriteAllText("Data/products1.json", updatedJsonString, System.Text.Encoding.UTF8);
        }

    }
}
