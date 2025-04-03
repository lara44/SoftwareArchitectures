
using HexagonalArchitecture.Core.Application.Services.Product.CreateProduct;
using HexagonalArchitecture.Domain.Product.Repository;

namespace HexagonalArchitecture.Application.Services.Product.CreateProduct
{
    public class CreateProductCommandHandler : ICreateProductCommandHandler
    {
        private readonly IProductRepository _productRepository;
        public CreateProductCommandHandler(
            IProductRepository productRepository
        )
        {
            _productRepository = productRepository;
        }

        public async Task Execute(CreateProductCommand request)
        {
            var product = Domain.Product.Product.Create(request.Name!, request.Price);
            await _productRepository.AddAsync(product);
        }
    }
}