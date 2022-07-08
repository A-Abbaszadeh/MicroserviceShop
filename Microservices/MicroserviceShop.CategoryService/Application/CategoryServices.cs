using MicroserviceShop.CategoryService.Domain;
using System;
using System.Collections.Generic;

namespace MicroserviceShop.CategoryService.Application
{
    public class CategoryServices : ICategoryServices
    {
        public List<Category> GetAll()
        {
            return new List<Category>()
            {
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Electronic Devices"
                },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Apparel"
                }
            };
        }
    }
}
