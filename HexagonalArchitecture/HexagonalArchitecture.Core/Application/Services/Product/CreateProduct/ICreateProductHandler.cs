

using HexagonalArchitecture.Core.Application.Services.Product.CreateProduct;

namespace HexagonalArchitecture.Core.Application.Services.ProductService.Interfaces
{
    public interface ICreateProductHandler
    {
       Task Execute(CreateProduct request); 
    }
}