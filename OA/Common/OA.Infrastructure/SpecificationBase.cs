using OA.Entities;
using OA.Infrastructure.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Infrastructure
{
    public abstract class SpecificationBase<T> : ISpecification<T> where T: IEntity
    {
        public abstract bool IsSatisfiedBy(T obj);     
        public List<string> Errors { get; set; }
        public OAExceptionBase Notify()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Errors.ForEach(err => stringBuilder.AppendLine(err));

            OAExceptionBase exceptionBase = new OAExceptionBase("Common", stringBuilder.ToString());
            return exceptionBase;
        }
    }
   
}
