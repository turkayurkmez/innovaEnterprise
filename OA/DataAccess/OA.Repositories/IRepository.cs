using OA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repositories
{
    public interface IRepository<T> where T:class, IEntity,new()
    {
        Task<IList<T>> GetAll();
        Task<T> Get(int id);
        Task<int> Add(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
    }
}
