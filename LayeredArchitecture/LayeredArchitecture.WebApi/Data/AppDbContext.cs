using LayeredArchitecture.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace LayeredArchitecture.WebApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}