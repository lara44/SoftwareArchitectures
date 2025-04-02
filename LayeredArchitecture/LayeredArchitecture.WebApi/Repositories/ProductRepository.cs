using LayeredArchitecture.WebApi.Data;
using LayeredArchitecture.WebApi.Data.Entities;
using LayeredArchitecture.WebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LayeredArchitecture.WebApi.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(ProductEntity product)
        {
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductEntity>> GetAllAsync()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }
    }
}