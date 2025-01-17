﻿using HomeWork3.Data;
using HomeWork3.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork3.Repositories
{
    public class EFProductRepository : IProductRepository
    {

        private readonly ProductDbContext _context;

        public EFProductRepository(ProductDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllAsync(string key = "")
        {
            var keyCode = key.Trim().ToLower();
            return keyCode != "" ? await _context
                .Products
                .Where(i => i.Name.ToLower().Contains(keyCode))
                .ToListAsync() :
                await _context.Products.ToListAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Product product)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

    }
}
