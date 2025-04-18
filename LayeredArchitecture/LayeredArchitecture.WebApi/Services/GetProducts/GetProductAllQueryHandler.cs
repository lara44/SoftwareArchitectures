using ATCMediator.Mediator.Interfaces;
using LayeredArchitecture.WebApi.Data.Entities;
using LayeredArchitecture.WebApi.Repositories.Interfaces;

namespace LayeredArchitecture.WebApi.Services.GetProducts
{
    public class GetProductAllQueryHandler : IQueryHandler<GetProductAllQuery, IEnumerable<ProductEntity>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductAllQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductEntity>> Handle(GetProductAllQuery query)
        {
            return await _productRepository.GetAllAsync();
        }
    }
}