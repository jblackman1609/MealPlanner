namespace MealPlanner.SharedKernel.Application
{
    public class Response<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; }
        public string? Message { get; set; }

        public Response(T? data, bool success, string? message)
        {
            Data = data;
            Success = success;
            Message = message;
        }
    }
}