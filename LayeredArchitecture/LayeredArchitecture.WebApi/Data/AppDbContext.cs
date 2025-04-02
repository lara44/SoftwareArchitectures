
using LayeredArchitecture.WebApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LayeredArchitecture.WebApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}