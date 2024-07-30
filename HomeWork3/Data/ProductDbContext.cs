using HomeWork3.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeWork3.Data
{
    public class ProductDbContext : DbContext
    {

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

    }
}
