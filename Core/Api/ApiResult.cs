using System.Net;

namespace Core.Api
{
    public class ApiResult
    {
        public HttpStatusCode Code { get; set; }
        public string Message { get; set; }

        public ApiResult(HttpStatusCode statusCode, string message)
        {
            Code = statusCode;
            Message = message;
        }
    }
}