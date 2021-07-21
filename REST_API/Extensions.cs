using REST_API.DTOs.Category;
using REST_API.Entities;

namespace REST_API
{
    public static class Extensions
    {
        public static CategoryResponse ToCategoryResponse(this Category category)
        {
            return new CategoryResponse
            {
                Id = category.Id,
                Name = category.Name
            };
        }
    }
}