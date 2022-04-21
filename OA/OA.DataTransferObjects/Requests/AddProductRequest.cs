using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.DataTransferObjects.Requests
{
    public class AddProductRequest
    {
        [Required(ErrorMessage = "Ürün adı boş olamaz")]
        [MinLength(3, ErrorMessage = "Ürün adı en az 3 karakter olmalıdır")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int CategoryId { get; set; }
        public string? ImageUrl { get; set; }
    }
}
