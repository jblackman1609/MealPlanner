namespace MealPlanner.SharedKernel.Application;

/// <summary>
/// Represents a generic response class that encapsulates the result of an operation, including the data, success status, 
/// and an optional message.
/// </summary>
/// <typeparam name="T"></typeparam>
public class Response<T>
{
    /// <summary>
    /// Gets or sets the data associated with the response. This property can hold any type of data, allowing for flexibility 
    /// in representing the outcome of the operation. 
    /// </summary>
    public T? Data { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the operation was successful. This property is a boolean flag that can be used
    /// to determine the success or failure of the operation, enabling consumers of the response to handle the result accordingly.
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// Gets or sets an optional message providing additional information about the response. This property can be used to convey
    /// error messages, success messages, or any other relevant information related to the operation's outcome.
    /// </summary>
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// Initializes a new instance of the Response class with the specified data, success status, and message. This constructor allows
    /// for the creation of a response object that encapsulates the result of an operation, providing a standardized way to 
    /// communicate the outcome to consumers of the response.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="success"></param>
    /// <param name="message"></param>
    public Response(T? data, bool success, string message)
    {
        Data = data;
        Success = success;
        Message = message;
    }
}