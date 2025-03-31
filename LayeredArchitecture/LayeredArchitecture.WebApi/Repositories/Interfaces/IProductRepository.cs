
using LayeredArchitecture.WebApi.Entities;

namespace LayeredArchitecture.WebApi.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task<List<Product>> GetAllAsync();
    }
}