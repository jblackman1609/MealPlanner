namespace MealPlanner.SharedKernel.Application;

/// <summary>
/// Represents a generic response class that encapsulates the result of an operation, including the data, 
/// success status, and an optional message.  
/// </summary>
/// <typeparam name="T"></typeparam>
public class Response<T>
{
    /// <summary>
    /// Gets or sets the data associated with the response. This property can hold any type of data, allowing 
    /// for flexibility in representing the outcome of the operation. 
    /// </summary>
    public T? Data { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the operation was successful. This property is a boolean flag that
    /// indicates the success status of the operation, allowing consumers to easily determine if the operation 
    /// completed successfully.
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// Gets or sets an optional message associated with the response. This property can hold additional information
    /// about the outcome of the operation, such as error messages or success messages, providing context to consumers 
    /// of the response.
    /// </summary>
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// Initializes a new instance of the Response class with the specified data, success status, and message. 
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