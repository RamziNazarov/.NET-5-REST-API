using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REST_API.DTOs.Product;
using REST_API.Entities;
using REST_API.Repositories;

namespace REST_API.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductResponse>> GetAll()
        {
            var products = await _productRepository.GetAllAsync();
            return products.Select(x => x.ToProductResponse());
        }

        [HttpPost]
        public ProductResponse Create(CreateProductRequest request)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                CategoryId = request.CategoryId
            };
            _productRepository.CreateAsync(product);
            return product.ToProductResponse();
        }

        [HttpGet]
        [Route("getallwithcategories")]
        public async Task<IEnumerable<ProductWithCategoryResponse>> GetAllWithCategories()
        {
            var products = await _productRepository.GetAllWithCategoriesAsync();
            return products.Select(x => x.ToProductWithCategoryResponse());
        }
    }
}