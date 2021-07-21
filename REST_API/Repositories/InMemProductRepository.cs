using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REST_API.Entities;

namespace REST_API.Repositories
{
    public class InMemProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository;

        public InMemProductRepository(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        
        private readonly List<Product> _products = new();
        
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await Task.FromResult(_products);
        }

        public void CreateAsync(Product product)
        {
            _products.Add(product);
        }

        public async Task<IEnumerable<Product>> GetAllWithCategoriesAsync()
        {
            return await Task.FromResult(_products.Select(x => new Product
            {
                Id = x.Id,
                Name = x.Name,
                CategoryId = x.CategoryId,
                Category = _categoryRepository.GetCategoryAsync(x.CategoryId).Result
            }));
        }
    }
}