
namespace ATCMediator.Mediator
{
    public interface IMediator
    {
        Task<TResult> Execute<TResult>(ICommand<TResult> command, CancellationToken cancellationToken = default);
        Task<TResult> Execute<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default);
    }
}