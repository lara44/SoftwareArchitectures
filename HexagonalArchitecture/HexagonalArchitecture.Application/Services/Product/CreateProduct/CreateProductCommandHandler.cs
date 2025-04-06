
using ATCMediator.Mediator;
using HexagonalArchitecture.Core.Application.Services.Product.CreateProduct;
using HexagonalArchitecture.Domain.Product.Repository;

namespace HexagonalArchitecture.Application.Services.Product.CreateProduct
{
    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand>
    {
        private readonly IProductRepository _productRepository;

        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task Handle(CreateProductCommand command)
        {
            var product = Domain.Product.Product.Create(command.Name!, command.Price);
            await _productRepository.AddAsync(product);
        }
    }
}