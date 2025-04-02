
namespace HexagonalArchitecture.Core.Domain.Product.Repository
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task<IEnumerable<Product>> GetAllAsync();
    }
}