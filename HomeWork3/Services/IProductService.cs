using HomeWork3.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeWork3.Services
{
    public interface IProductService
    {

        Task<List<Product>> GetAllByKey(string key);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(string id);

    }
}
