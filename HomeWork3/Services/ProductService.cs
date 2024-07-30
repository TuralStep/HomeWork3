using HomeWork3.Entities;
using HomeWork3.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeWork3.Services
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task AddAsync(Product product)
        {
            await _productRepository.AddAsync(product);
        }

        public async Task DeleteAsync(string id)
        {
            await _productRepository.DeleteAsync(id);
        }

        public async Task<List<Product>> GetAllByKey(string key)
        {
            return await _productRepository.GetAllAsync(key);
        }

        public async Task UpdateAsync(Product product)
        {
            await _productRepository.UpdateAsync(product);
        }
    }
}
