using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using REST_API.DTOs.Category;
using REST_API.Entities;

namespace REST_API.Repositories
{
    public class InMemCategoryRepository : ICategoryRepository
    {
        private List<Category> _categories = new List<Category>
        {
            new Category
            {
                Id = Guid.NewGuid(),
                Name = "Fruits"
            }
        };
        
        public async Task<List<Category>> GetAllAsync()
        {
            return await Task.FromResult(_categories);
        }
    }
}