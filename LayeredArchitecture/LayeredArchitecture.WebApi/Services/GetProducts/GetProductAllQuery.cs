using ATCMediator.Mediator.Interfaces;
using LayeredArchitecture.WebApi.Data.Entities;

namespace LayeredArchitecture.WebApi.Services.GetProducts
{
    public class GetProductAllQuery : IQuery<IEnumerable<ProductEntity>> 
    {
    }
}