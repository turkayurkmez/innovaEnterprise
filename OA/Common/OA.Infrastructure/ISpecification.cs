using OA.Entities;
using OA.Infrastructure.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Infrastructure
{
    public interface ISpecification<T> where T:IEntity
    {
        bool IsSatisfiedBy(T entity);
        OAExceptionBase Notify();
        
    }
}
