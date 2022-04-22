using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.DataTransferObjects.Responses
{
    [Serializable]
    public class ProductDisplayResponse 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? CategoryId { get; set; }
        public string? ImageUrl { get; set; }
        public string CategoryName { get; set; }
    }
}
