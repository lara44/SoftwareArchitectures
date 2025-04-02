
using LayeredArchitecture.WebApi.Data.Entities;
using LayeredArchitecture.WebApi.Repositories.Interfaces;
using LayeredArchitecture.WebApi.Services.Interfaces;

namespace LayeredArchitecture.WebApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(
            IProductRepository productRepository
        )
        {
            _productRepository = productRepository;
        }

        public async Task CrearProductoAsync(string name, decimal price)
        {
            var product = new ProductEntity { Name = name, Price = price };
            await _productRepository.AddAsync(product);
        }

        public async Task<IEnumerable<ProductEntity>> ObtenerProductosAsync()
        {
            return await _productRepository.GetAllAsync();
        }
    }
}