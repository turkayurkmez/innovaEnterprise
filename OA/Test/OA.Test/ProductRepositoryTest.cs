using Moq;
using OA.Data.Context;
using OA.Entities;
using OA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OA.Test
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void Add_Product_with_repository()
        {
            Mock<InnovaDbContext> mock = new Mock<InnovaDbContext>();
            mock.Setup(x => x.Add(It.IsAny<Product>()));
            EFProductRepository eFProductRepository = new EFProductRepository(mock.Object);
            var result = eFProductRepository.Add(It.IsAny<Product>());
            Assert.NotNull(result);

        }
    }
}
