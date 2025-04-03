
namespace HexagonalArchitecture.Domain.Product.Repository
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task<IEnumerable<Product>> GetAllAsync();
    }
}