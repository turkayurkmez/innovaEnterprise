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
        public async Task<int> Add(Product entity)
        {
            await context.Products.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity.Id;

        }

        public Task Delete(int id)
        {
            var product = context.Products.FirstOrDefault(p => p.Id == id);
            context.Products.Remove(product);
            return context.SaveChangesAsync();
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

        public async Task<bool> IsExists(int id)
        {
           return await  context.Products.AnyAsync(x => x.Id == id);
        }

        public Task<IEnumerable<Product>> Search(string search)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(Product entity)
        {
            context.Products.Update(entity);
            var affectedRows = await context.SaveChangesAsync();
            return affectedRows;
        }
    }
}
