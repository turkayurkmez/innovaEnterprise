using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Infrastructure.Extensions
{
    public static class ExpandoExtensions
    {
        public static void AddAnonymousType(this ExpandoObject expando, object anonymousType)
        {
            var expandoDict = expando as IDictionary<string, object>;
            if (anonymousType is IEnumerable)
            {
                expandoDict.TryAdd("List", anonymousType);
            }
            else
            {
                foreach (var property in anonymousType.GetType().GetProperties())
                {
                    expandoDict.TryAdd(property.Name, property.GetValue(anonymousType));
                }
            }        
           
        }
    }
}
