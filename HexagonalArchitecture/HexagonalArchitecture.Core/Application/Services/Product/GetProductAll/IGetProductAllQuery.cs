

namespace HexagonalArchitecture.Core.Application.Services.Product.GetProductAll
{
    public interface IGetProductAllQuery
    {
        Task <IEnumerable<Domain.Product.Product>> Execute();
    }
}