using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using OA.Services;

namespace OA.API.Filters
{
    public class IsExistsOperation : IAsyncActionFilter
    {
        private IProductService productService;

        public IsExistsOperation(IProductService productService)
        {
            this.productService = productService;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ActionArguments.ContainsKey("id"))
            {
                context.Result = new BadRequestObjectResult(new { message="id değeri yok!" });
            }
            else
            {
                int id = (int)(context.ActionArguments["id"]);
                if (!(await productService.IsProductExists(id)))
                {
                    context.Result = new NotFoundObjectResult(new { message = $"{id} id'li ürün yok!" });
                }
                else
                {
                    await next.Invoke();
                }
            }

           
        }
    }
}

