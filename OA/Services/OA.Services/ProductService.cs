using AutoMapper;
using OA.DataTransferObjects.Requests;
using OA.DataTransferObjects.Responses;
using OA.Entities;
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

        public async Task<int> AddProduct(AddProductRequest request)
        {
            var product = mapper.Map<Product>(request);
            product.DateCreated = DateTime.Now;
            int id = await productRepository.Add(product);
            return id;

        }

        public async Task Delete(int id)
        {
            await productRepository.Delete(id);
            
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

        public async Task<bool> IsProductExists(int id)
        {
            return await productRepository.IsExists(id);
        }

        public async Task<int> UpdateProduct(UpdateProductRequest request)
        {
            var product = mapper.Map<Product>(request);
            product.DateUpdated = DateTime.Now;
            return await productRepository.Update(product);
        }
    }
}
