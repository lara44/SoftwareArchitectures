
using ATCMediator.Mediator;

namespace HexagonalArchitecture.Core.Application.Services.Product.CreateProduct
{
    public class CreateProductCommand : ICommand<Guid>
    {
        public string? Name { get; set; }
        public decimal Price { get; set;}
    }
}