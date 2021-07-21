using REST_API.DTOs.Category;
using REST_API.DTOs.Product;
using REST_API.Entities;

namespace REST_API
{
    public static class Extensions
    {
        public static CategoryResponse ToCategoryResponse(this Category category)
        {
            return new()
            {
                Id = category.Id,
                Name = category.Name
            };
        }
        
        public static ProductResponse ToProductResponse(this Product product)
        {
            return new()
            {
                Id = product.Id,
                Name = product.Name
            };
        }
    }
}