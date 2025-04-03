
using HexagonalArchitecture.Domain.Product.Repository;

namespace HexagonalArchitecture.Application.Services.Product.GetProductAll
{
    public class GetProductAllQuery : IGetProductAllQuery
    {
        private readonly IProductRepository _productRepository;

        public GetProductAllQuery(
            IProductRepository productRepository
        )
        {
            _productRepository = productRepository;
        }
        public async Task<IEnumerable<Domain.Product.Product>> Execute()
        {
            var products = await _productRepository.GetAllAsync();
            return products;
        }
    }
}