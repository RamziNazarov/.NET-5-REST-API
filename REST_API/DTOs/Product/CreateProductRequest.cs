using System;

namespace REST_API.DTOs.Product
{
    public class CreateProductRequest
    {
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
    }
}