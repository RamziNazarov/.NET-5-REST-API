using System;

namespace REST_API.DTOs.Product
{
    public class ProductWithCategoryResponse
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
    }
}