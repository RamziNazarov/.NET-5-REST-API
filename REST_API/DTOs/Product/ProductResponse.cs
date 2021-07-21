using System;

namespace REST_API.DTOs.Product
{
    public class ProductResponse
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
    }
}