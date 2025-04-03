

using HexagonalArchitecture.Core.Application.Services.Product.CreateProduct;

namespace HexagonalArchitecture.Application.Services.Product.CreateProduct
{
    public interface ICreateProductCommandHandler
    {
       Task Execute(CreateProductCommand request); 
    }
}