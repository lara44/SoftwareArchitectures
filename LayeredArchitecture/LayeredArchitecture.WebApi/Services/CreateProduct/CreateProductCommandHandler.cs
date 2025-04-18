
using ATCMediator.Mediator.Interfaces;
using LayeredArchitecture.WebApi.Data.Entities;
using LayeredArchitecture.WebApi.Repositories.Interfaces;

namespace LayeredArchitecture.WebApi.Services.CreateProduct
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
            var product = new ProductEntity { Name = command.Name, Price = command.Price };
            await _productRepository.AddAsync(product);
        }
    }
}