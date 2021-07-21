using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REST_API.DTOs.Category;
using REST_API.Repositories;

namespace REST_API.Controllers
{
    [ApiController]
    [Route("categories")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryResponse>> GetALl()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return categories.Select(x => x.ToCategoryResponse());
        }
    }
}