/// <summary>
/// Represents a handler for processing requests in the application layer. It defines a contract for handling a specific 
/// type of request and producing a corresponding response. The handler is responsible for implementing the business logic 
/// associated with the request and returning the appropriate response.
/// </summary>
/// <typeparam name="TRequest"></typeparam>
/// <typeparam name="TResponse"></typeparam>
public interface IRequestHandler<in TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    /// <summary>
    /// Handles the specified request and produces a corresponding response. The method is asynchronous, allowing for
    /// non-blocking operations and efficient resource utilization. The cancellationToken parameter allows for cooperative
    /// cancellation of the operation.
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken = default);
}