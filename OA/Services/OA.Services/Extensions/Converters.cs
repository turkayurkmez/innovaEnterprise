using AutoMapper;
using OA.DataTransferObjects.Responses;
using OA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Services.Extensions
{
    public static  class Converters
    {
        public static List<ProductDisplayResponse> ConvertToDto(this IList<Product> products, IMapper mapper )
        {
            return mapper.Map<List<ProductDisplayResponse>>(products);

        }
    }
}
