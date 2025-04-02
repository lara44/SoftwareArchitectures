

using HexagonalArchitecture.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HexagonalArchitecture.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}