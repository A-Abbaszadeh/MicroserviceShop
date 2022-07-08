using MicroserviceShop.ProductService.Domain;
using System;
using System.Collections.Generic;

namespace MicroserviceShop.ProductService.Application
{
    public class ProductServices : IProductServices
    {
        public List<Product> GetAll()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.NewGuid(),
                    Name = "Laptop"
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.NewGuid(),
                    Name = "PC"
                },
            };
        }
    }
}
