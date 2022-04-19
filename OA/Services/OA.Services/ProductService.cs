using AutoMapper;
using OA.DataTransferObjects.Responses;
using OA.Repositories;
using OA.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper mapper;
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            this.mapper = mapper;
            this.productRepository = productRepository;
        }
        public async Task<IEnumerable<ProductDisplayResponse>> GetProducts()
        {
            var products = await productRepository.GetAll();
            //var productDisplayResponses =  products.Select(p => new ProductDisplayResponse
            //{
            //    Id = p.Id,
            //    Name = p.Name,
            //    Price = p.Price,
            //    Description = p.Description,               
            //    ImageUrl = p.ImageUrl
            //});

            var productDisplayResponses = products.ConvertToDto(mapper);

            return productDisplayResponses;

        }
    }
}
