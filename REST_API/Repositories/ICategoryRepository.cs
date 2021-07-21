using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using REST_API.DTOs.Category;
using REST_API.Entities;

namespace REST_API.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetCategoryAsync(Guid categoryId);
    }
}