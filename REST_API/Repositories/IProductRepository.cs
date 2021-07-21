using System.Collections.Generic;
using System.Threading.Tasks;
using REST_API.Entities;

namespace REST_API.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        void CreateAsync(Product product);
        Task<IEnumerable<Product>> GetAllWithCategoriesAsync();
    }
}