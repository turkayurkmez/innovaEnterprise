using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Entities
{
    //You aren't gonna need it: YAGNI
    public class Product : IEntity
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Ad alanı gereklidir.")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public string? ImageUrl { get; set; }

        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int Stock { get; set; } = 0;

      
        
    }
}
