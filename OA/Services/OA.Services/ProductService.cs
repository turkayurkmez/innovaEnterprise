using OA.DataTransferObjects.Responses;
using OA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public async  Task<IEnumerable<ProductDisplayResponse>> GetProducts()
        {
            var products = await productRepository.GetAll();
            var productDisplayResponses =  products.Select(p => new ProductDisplayResponse
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,               
                ImageUrl = p.ImageUrl
            });

            return productDisplayResponses;

        }
    }
}
