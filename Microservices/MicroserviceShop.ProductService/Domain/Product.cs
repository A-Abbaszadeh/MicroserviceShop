using System;

namespace MicroserviceShop.ProductService.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Guid? CategoryId { get; set; }
    }
}
