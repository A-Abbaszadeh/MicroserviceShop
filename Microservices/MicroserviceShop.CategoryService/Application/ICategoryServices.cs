using MicroserviceShop.CategoryService.Domain;
using System.Collections.Generic;

namespace MicroserviceShop.CategoryService.Application
{
    public interface ICategoryServices
    {
        List<Category> GetAll();
    }
}
