
using ATCMediator.Mediator.Interfaces;
using HexagonalArchitecture.Domain.Product.Repository;

namespace HexagonalArchitecture.Application.Services.Product.GetProductAll
{
    public class GetProductAllQueryHandler : IAtcRequestHandler<GetProductAllQuery, IEnumerable<Domain.Product.Product>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductAllQueryHandler(
            IProductRepository productRepository
        )
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Domain.Product.Product>> HandlerAsync(GetProductAllQuery request, CancellationToken cancellationToken = default)
        {
            var products = await _productRepository.GetAllAsync();
            return products;
        }
    }
}