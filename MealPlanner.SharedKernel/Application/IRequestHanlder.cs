namespace MealPlanner.SharedKernel.Application
{
    /// <summary>
    /// Represents a handler for processing requests in the application layer. A request handler is responsible for 
    /// handling a specific type of request and producing a corresponding response. The IRequestHandler interface 
    /// defines a contract for implementing request handlers, allowing them to be invoked by the application framework 
    /// or other components. The TRequest type parameter specifies the type of request that the handler can process, 
    /// while the TResponse type parameter specifies the expected response type that will be returned when the request 
    /// is handled.
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    public interface IRequestHandler<in TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        /// <summary>
        /// Handles the specified request and produces a corresponding response. This method is responsible for
        /// processing the request, performing any necessary operations or business logic, and returning the appropriate
        /// response. The cancellationToken parameter allows for cancellation of the request handling operation, enabling
        /// graceful termination of long-running or asynchronous operations if needed. The method returns a Task that represents 
        /// the asynchronous operation of handling the request, allowing for non-blocking execution and efficient resource utilization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken = default);
    }
}