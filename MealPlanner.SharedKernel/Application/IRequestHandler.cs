namespace MealPlanner.SharedKernel.Application;

/// <summary>
/// Represents a generic interface for handling request objects of type TRequest and producing a response of type TResponse.
/// </summary>
/// <typeparam name="TRequest"></typeparam>
/// <typeparam name="TResponse"></typeparam>
public interface IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    /// <summary>
    /// Processes the specified request of type TRequest and produces a response of type TResponse. This method is asynchronous 
    /// and can be awaited, allowing for non-blocking execution of request handling logic. The cancellationToken parameter allows 
    /// for cooperative cancellation of the operation, enabling graceful termination of the request handling process if needed.
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
}