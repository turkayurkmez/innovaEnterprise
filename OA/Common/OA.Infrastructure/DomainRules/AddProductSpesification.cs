using OA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Infrastructure.DomainRules
{
    public class AddProductSpesification : SpecificationBase<Product>
    {
        public override bool IsSatisfiedBy(Product obj)
        {
            if (string.IsNullOrEmpty(obj.Name))
            {
                this.Errors.Add("Name field cannot be empty");
            }

            if (obj.Id != 0)
            {
                Errors.Add("Id value must be 0");
            }

            if (Errors.Count > 0)
            {
                Notify();
                return false;
            }
            return true;
        }
    }
}
