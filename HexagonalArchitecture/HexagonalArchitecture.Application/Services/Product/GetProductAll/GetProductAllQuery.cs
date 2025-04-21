
using static ATCMediator.Mediator.Interfaces.IAtcRequest;

namespace HexagonalArchitecture.Application.Services.Product.GetProductAll
{
    public class GetProductAllQuery : IAtcRequest<IEnumerable<Domain.Product.Product>> 
    {
    }
}