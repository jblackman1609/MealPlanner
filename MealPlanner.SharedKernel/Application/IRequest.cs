namespace MealPlanner.SharedKernel.Application
{
    /// <summary>
    /// Represents a marker interface for requests in the application layer. A request is an object that encapsulates 
    /// the data and parameters needed to perform a specific operation or action within the application. The IRequest 
    /// interface serves as a base interface for all request types, allowing them to be handled by corresponding 
    /// request handlers. The TResponse type parameter specifies the expected response type that will be returned when 
    /// the request is processed.
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public interface IRequest<TResponse>
    {
    }    
}