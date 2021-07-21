using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REST_API.Entities;

namespace REST_API.Repositories
{
    public class InMemCategoryRepository : ICategoryRepository
    {
        private readonly List<Category> _categories = new()
        {
            new Category
            {
                Id = Guid.NewGuid(),
                Name = "Fruits"
            }
        };
        
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await Task.FromResult(_categories);
        }

        public async Task<Category> GetCategoryAsync(Guid categoryId)
        {
            return await Task.FromResult(_categories.SingleOrDefault(x => x.Id == categoryId));
        }
    }
}