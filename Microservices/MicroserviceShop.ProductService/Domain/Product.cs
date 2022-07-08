using System;

namespace MicroserviceShop.ProductService.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? CategoryId { get; set; }
    }
}
