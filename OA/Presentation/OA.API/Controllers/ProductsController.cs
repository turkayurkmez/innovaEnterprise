using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA.Services;

namespace OA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        //[ResponseCache(Duration =60)]
        public async Task<IActionResult> Get()
        {
            var products = await productService.GetProducts();
            return Ok(products);
        }
    }
}
