using MicroserviceShop.ProductService.Domain;
using System.Collections.Generic;

namespace MicroserviceShop.ProductService.Application
{
    public interface IProductServices
    {
        List<Product> GetAll();
    }
}
