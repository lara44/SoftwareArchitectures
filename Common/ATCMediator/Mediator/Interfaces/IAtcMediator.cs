

using static ATCMediator.Mediator.Interfaces.IAtcRequest;

namespace ATCMediator.Mediator.Interfaces
{
    public interface IAtcMediator
    {
        Task<TResult> ExecuteAsync<TResult>(IAtcRequest<TResult> atcRequest, CancellationToken cancellationToken = default);
    }
}