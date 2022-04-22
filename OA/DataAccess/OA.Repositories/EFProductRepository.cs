using Microsoft.EntityFrameworkCore;
using OA.Data.Context;
using OA.Entities;
using OA.Infrastructure.DomainRules;
using OA.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Dynamic;
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
            AddProductSpesification productSpesification = new AddProductSpesification();
            var isSatisfied = productSpesification.IsSatisfiedBy(entity);
            if (isSatisfied)
            {
                await context.Products.AddAsync(entity);
                await context.SaveChangesAsync();
                return entity.Id;
            }
            else
            {
                throw productSpesification.Notify();
            }





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
            // TODO 1: use eager loading          
            return await context.Products.Include(x=>x.Category).ToListAsync();

        }

        public ExpandoObject Test()
        {
            var expando = new ExpandoObject();
            var result = context.Categories.FromSqlRaw("SELECT * FROM Products").Select(p => new { Id = p.Id, Name = p.Name }).ToList();  
           
            expando.AddAnonymousType(result);



            return expando;
        }

        public Task<IEnumerable<Product>> GetProductsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsExists(int id)
        {
            return await context.Products.AnyAsync(x => x.Id == id);
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
