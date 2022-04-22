using Newtonsoft.Json;

namespace OA.API.Infrastructure
{
    public class PostLoggerMiddleware
    {
        RequestDelegate _next;
        public PostLoggerMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine($" Gelen request metodu: {context.Request.Method}");
            var isJsonContent = context.Request.HasJsonContentType();
            if (isJsonContent)
            {
                var body = context.Request.ReadFromJsonAsync<object>();
                var jsonBody = JsonConvert.DeserializeObject<dynamic>(body.ToString());
                Console.WriteLine($" Gelen request body: {jsonBody.ToString()}");
            }

            await _next.Invoke(context);
        }
    }
}
