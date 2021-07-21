using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using REST_API.Entities;

namespace REST_API.Repositories
{
    public class InMemProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new();
        
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await Task.FromResult(_products);
        }
    }
}