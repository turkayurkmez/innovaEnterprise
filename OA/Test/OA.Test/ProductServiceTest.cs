using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using OA.Entities;
using OA.Repositories;
using OA.Services;
using OA.Services.Mapping;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace OA.Test
{
    public class ProductServiceTest
    {
        [Fact]
        public async void Getting_Products()
        {
            Mock<IProductRepository> mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(m => m.GetAll()).Returns(Task.Run(() =>
                       (IList<Product>)new List<Product>
                       {
                           new Product { Id = 1, Name = "Test" }
                       }));

            var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            var mapper = config.CreateMapper();


            ProductService productService = new ProductService(mockProductRepository.Object, mapper);

            //act:
            var products = await productService.GetProducts();
            Assert.NotEmpty(products);
            Assert.Equal("Test", products.First().Name);
        }
    }
}