
using ATCMediator.Mediator.Interfaces;
using static ATCMediator.Mediator.Interfaces.IAtcRequest;

namespace ATCMediator.Mediator
{
    public class AtcMediator(IServiceProvider serviceProvider) : IAtcMediator
    {
        public async Task<TResult> ExecuteAsync<TResult>(IAtcRequest<TResult> atcRequest, CancellationToken cancellationToken = default)
        {
            var handlerType = typeof(IAtcRequestHandler<,>).MakeGenericType(atcRequest.GetType(), typeof(TResult));
            dynamic handler = serviceProvider.GetService(handlerType)
                            ?? throw new InvalidOperationException($"No se encontró handler para {handlerType.Name}");

            return await handler.HandlerAsync((dynamic)atcRequest);
        }
    }
}