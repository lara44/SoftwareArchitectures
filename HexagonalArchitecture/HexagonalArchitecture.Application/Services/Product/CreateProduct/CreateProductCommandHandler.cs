

using ATCMediator.Mediator.Interfaces;
using HexagonalArchitecture.Core.Application.Services.Product.CreateProduct;
using HexagonalArchitecture.Domain.Product.Repository;

namespace HexagonalArchitecture.Application.Services.Product.CreateProduct
{
    public class CreateProductCommandHandler : IAtcRequestHandler<CreateProductCommand, Guid>  
    {
        private readonly IProductRepository _productRepository;

        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Guid> HandlerAsync(CreateProductCommand command, CancellationToken cancellationToken = default)
        {
            var product = Domain.Product.Product.Create(command.Name!, command.Price);
            await _productRepository.AddAsync(product);
            return product.Id;
        }
    }
}