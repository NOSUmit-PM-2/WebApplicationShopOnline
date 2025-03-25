using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private static List<Product> products = new List<Product>()
        {
            new Product("Чебурек", "с сыром", 120, "/images/Chebureki.jpg"),
            new Product("Пирожок", "печеный", 50, "https://cdn.foodpicasso.com/assets/2022/05/30/2d5c997edd5a1c47de33aa05a85dc987---png_1000x_103c0_convert.png"),
            new Product("Шаурма", "детская", 320, "https://bistromania.ru/wp-content/uploads/2022/02/%D1%88%D0%B0%D1%83%D1%80%D0%BC%D0%B0-%D0%B8-%D1%88%D0%B0%D1%83%D1%80%D0%BC%D0%B0-%D0%BC%D0%B8%D0%BD%D0%B8.jpg")
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
