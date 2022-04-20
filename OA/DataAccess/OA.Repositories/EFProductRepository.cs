using Microsoft.EntityFrameworkCore;
using OA.Data.Context;
using OA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private readonly InnovaDbContext context;

        public EFProductRepository(InnovaDbContext context)
        {
            this.context = context;
        }
        public async  Task<int> Add(Product entity)
        {
            await context.Products.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity.Id;

        }

        public Task Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Product>> GetAll()
        {
            return await context.Products.ToListAsync();
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
    }
}
