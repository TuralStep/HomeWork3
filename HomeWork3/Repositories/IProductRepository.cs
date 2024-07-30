using HomeWork3.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeWork3.Repositories
{
    public interface IProductRepository
    {

        Task<List<Product>> GetAllAsync(string key = "");
        Task AddAsync(Product product);

    }
}
