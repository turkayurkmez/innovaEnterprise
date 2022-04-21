using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace OA.API.Filters
{
    public class CustomException : ExceptionFilterAttribute
    {
        public override Task OnExceptionAsync(ExceptionContext context)
        {
            return base.OnExceptionAsync(context);
        }

        public override void OnException(ExceptionContext context)
        {
           
            
            var response = new  { message = "Field not found" };

            context.Result = new BadRequestObjectResult(response);

            base.OnException(context);
        }
    }
}
