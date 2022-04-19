﻿using OA.DataTransferObjects.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDisplayResponse>> GetProducts();
     
    }
}
