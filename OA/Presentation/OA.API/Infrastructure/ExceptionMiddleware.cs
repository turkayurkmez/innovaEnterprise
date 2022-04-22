using System.Net;

namespace OA.API.Infrastructure
{
    public class ExceptionMiddleware : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                return next(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                return context.Response.WriteAsync(new ErrorDetails()
                {
                    StatusCode = context.Response.StatusCode,
                    Message = "Internal Server Error from the custom middleware."
                }.ToString());
            }
        }
    }
}
