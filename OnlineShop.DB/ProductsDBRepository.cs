

namespace OnlineShop.DB
{
    public class ProductsDBRepository : IProductDBsRepository
    {

        static List<ProductDB> products = new List<ProductDB>();

        public List<ProductDB> GetAll()
        {
            return products;
        }

        public void Add(ProductDB product)
        {
            products.Add(product);
        }

        public ProductDB TryGetById(Guid id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }

        public void Updata(ProductDB product)
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
        }


    }
}
