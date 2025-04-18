
using ATCMediator.Mediator.Interfaces;

namespace LayeredArchitecture.WebApi.Services.CreateProduct
{
     public class CreateProductCommand : ICommand
    {
        public string? Name { get; set; }
        public decimal Price { get; set;}
    }
}