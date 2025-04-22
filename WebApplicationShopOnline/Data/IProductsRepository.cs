﻿using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public interface IProductsRepository
    {
        List<Product> GetAll();
        Product TryGetById(int id);
        void Add(Product product);
    }
}