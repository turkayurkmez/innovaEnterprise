using OA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repositories
{
    public class FakeProductRepository : IProductRepository
    {

        private List<Product> products = new List<Product>();
        public FakeProductRepository()
        {
            products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Product 1", Price = 10 },
                new Product() { Id = 2, Name = "Product 2", Price = 20 },
                new Product() { Id = 3, Name = "Product 3", Price = 30 },
                new Product() { Id = 4, Name = "Product 4", Price = 40 },
                new Product() { Id = 5, Name = "Product 5", Price = 50 },
            };
        }

        public Task<int> Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Get(int id)
        {
            throw new NotImplementedException();
        }

     

        public Task<IEnumerable<Product>> GetProductsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> Search(string search)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Update(Product entity)
        {
            throw new NotImplementedException();
        }
        
       public async Task<IList<Product>> GetAll()
        {
            return products;
        }
    }
  
}
