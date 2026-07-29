namespace MealPlanner.SharedKernel.Application
{
    /// <summary>
    /// Represents a generic response object that encapsulates the result of an operation or request 
    /// in the application layer.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Response<T>
    {
        /// <summary>
        /// Gets or sets the data associated with the response. This property holds the result or output 
        /// of the operation, allowing it to be accessed and utilized by the caller. The Data property is 
        /// typically set when the response is created, and it can be of any type specified by the generic parameter T.
        /// </summary>    
        public T? Data { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the operation was successful. This property is used to
        /// communicate the outcome of the operation, allowing the caller to determine if the request was
        /// successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets an optional message providing additional information about the response. This property
        /// can be used to convey error messages, status updates, or other relevant details about the operation's outcome.
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Initializes a new instance of the Response class with the specified data, success status, and optional message. 
        /// This constructor allows the caller to create a response object that encapsulates the result of an operation, 
        /// including the data, success status, and any relevant messages.
        /// </summary>
        /// <param name="data">The data associated with the response.</param>
        /// <param name="success">A value indicating whether the operation was successful.</param>
        /// <param name="message">An optional message providing additional information about the response.</param>
        public Response(T? data, bool success, string? message)
        {
            Data = data;
            Success = success;
            Message = message;
        }
    }
}