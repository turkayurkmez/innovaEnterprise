using OA.Entities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsByCategory(int categoryId);
        Task<IEnumerable<Product>> Search(string search);

        ExpandoObject Test();
    }
    
}
