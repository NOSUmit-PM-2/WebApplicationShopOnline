using OnlineShop.DB;

namespace WebApplicationShopOnline.Models
{
    public class Mapping
    {
        public static Product ToProduct(ProductDB product)
        {
            return new Product
            {
                Name = product.Name,
                Description = product.Description,
                Cost = product.Cost,
                PathImage = product.PathImage,
                Id = product.Id
            };
        }

        public static ProductDB ToProductDB(Product product)
        {
            return new ProductDB
            {
                Name = product.Name,
                Description = product.Description,
                Cost = product.Cost,
                PathImage = product.PathImage,
                Id = product.Id
            };
        }

        public static List<Product> ToProductList(List<ProductDB> productDBs) 
        { 
            List<Product> products = new List<Product>();
            foreach(var product in productDBs)
                products.Add(ToProduct(product));
            return products;
        }

        public static List<ProductDB> ToProductDBList(List<Product> products)
        {
            List<ProductDB> productDBs = new List<ProductDB>();
            foreach (var product in products)
                productDBs.Add(ToProductDB(product));
            return productDBs;
        }

    }
}
