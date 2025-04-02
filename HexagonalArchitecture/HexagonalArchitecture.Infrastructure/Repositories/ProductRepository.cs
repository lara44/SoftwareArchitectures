
using HexagonalArchitecture.Core.Domain.Product;
using HexagonalArchitecture.Core.Domain.Product.Repository;
using HexagonalArchitecture.Infrastructure.Data;
using HexagonalArchitecture.Infrastructure.Mappers;
using Microsoft.EntityFrameworkCore;

namespace HexagonalArchitecture.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddAsync(Product product)
        {
            var productEntity = ProductMapper.ToDomainEntity(product);
            await _context.Products.AddAsync(productEntity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var products = await _context.Products.ToListAsync();
            return products.Select(ProductMapper.MapToDomainForQuery);
        }
    }
}