

using HexagonalArchitecture.Core.Application.Services.ProductService.Interfaces;
using HexagonalArchitecture.Core.Domain.Product.Repository;

namespace HexagonalArchitecture.Core.Application.Services.Product
{
    public class CreateProductHandler : ICreateProductHandler
    {
        private readonly IProductRepository _productRepository;
        public CreateProductHandler(
            IProductRepository productRepository
        )
        {
            _productRepository = productRepository;
        }

        public async Task Execute(CreateProduct.CreateProduct request)
        {
            var product = Domain.Product.Product.Create(request.Name!, request.Price);
            await _productRepository.AddAsync(product);
        }
    }
}