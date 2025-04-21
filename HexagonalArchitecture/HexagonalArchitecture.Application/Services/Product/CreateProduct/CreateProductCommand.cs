
using static ATCMediator.Mediator.Interfaces.IAtcRequest;

namespace HexagonalArchitecture.Core.Application.Services.Product.CreateProduct
{
    public class CreateProductCommand : IAtcRequest<Guid>
    {
        public string? Name { get; set; }
        public decimal Price { get; set;}
    }
}