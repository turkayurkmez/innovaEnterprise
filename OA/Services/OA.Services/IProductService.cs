using OA.DataTransferObjects.Requests;
using OA.DataTransferObjects.Responses;
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
        Task<int> AddProduct(AddProductRequest request);
        Task<int> UpdateProduct(UpdateProductRequest request);
        Task Delete(int id);

        Task<bool> IsProductExists(int id);


    }
}
