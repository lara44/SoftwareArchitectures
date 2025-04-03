
using HexagonalArchitecture.Domain.Product.Repository;
using HexagonalArchitecture.Infrastructure.Data;
using HexagonalArchitecture.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HexagonalArchitecture.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            // Configurar Entity Framework Core con PostgreSQL
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
            );

            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}