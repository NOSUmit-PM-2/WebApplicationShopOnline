﻿

namespace OnlineShop.DB
{
    public class ProductsDBRepository : IProductDBsRepository
    {

        private readonly DatabaseContext dbContext;

        public ProductsDBRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<ProductDB> GetAll()
        {
            return dbContext.ProductDBs.ToList();
        }

        public void Add(ProductDB product)
        {
            dbContext.ProductDBs.Add(product);
            dbContext.SaveChangesAsync();
        }

        public ProductDB TryGetById(Guid id)
        {
            return dbContext.ProductDBs.FirstOrDefault(x => x.Id == id);
        }

        public void Updata(ProductDB product)
        {
            var existingProduct = dbContext.ProductDBs.FirstOrDefault
                                    (x => x.Id == product.Id);
            if (existingProduct == null)
            {
                return;
            }
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Cost = product.Cost;
            existingProduct.PathImage = product.PathImage;
            dbContext.SaveChangesAsync();
        }


    }
}
