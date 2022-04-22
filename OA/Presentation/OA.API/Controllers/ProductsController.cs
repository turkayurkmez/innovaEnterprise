using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA.API.Filters;
using OA.DataTransferObjects.Requests;
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
        [CustomException]

        public async Task<IActionResult> Get()
        {
            var products = await productService.GetProducts();        
            return Ok(products);
        }

        [HttpGet("{id}")]


        public async Task<IActionResult> Get(int id)
        {
            var products = await productService.GetProducts();
            return Ok(products);
        }


        [HttpGet("Search/{name}")]

        public async Task<IActionResult> Get(string name)
        {
            var products = await productService.GetProducts();
            return Ok(products);
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddProductRequest request)
        {
            if (ModelState.IsValid)
            {
                var id = await productService.AddProduct(request);
                return CreatedAtAction(nameof(Get), routeValues: new { id = id }, null);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        [IsExists]
        public async Task<IActionResult> Update(int id, UpdateProductRequest request)
        {

            if (ModelState.IsValid)
            {
                await productService.UpdateProduct(request);
                return Ok();
            }
            return BadRequest(ModelState);


        }
        [HttpDelete("{id}")]
        [IsExists]
        public async Task<IActionResult> Delete(int id)
        {
            await productService.Delete(id);
            return Ok();
        }



    }
}
