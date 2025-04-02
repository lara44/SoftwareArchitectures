

using HexagonalArchitecture.Core.Domain.Product;
using HexagonalArchitecture.Infrastructure.Data.Entities;

namespace HexagonalArchitecture.Infrastructure.Mappers
{
    public static class ProductMapper
    {
        public static ProductEntity ToDomainEntity(Product product)
        {
            return new ProductEntity
            {
                Name = product.Name,
                Price = product.Price
            };
        }
        public static Product MapToDomainForQuery(ProductEntity productEntity)
        {
            return Product.Create(productEntity.Name!, productEntity.Price);
        }
    }
}