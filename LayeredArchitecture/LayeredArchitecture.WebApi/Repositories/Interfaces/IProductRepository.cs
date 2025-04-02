
using LayeredArchitecture.WebApi.Data.Entities;

namespace LayeredArchitecture.WebApi.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task AddAsync(ProductEntity product);
        Task<IEnumerable<ProductEntity>> GetAllAsync();
    }
}