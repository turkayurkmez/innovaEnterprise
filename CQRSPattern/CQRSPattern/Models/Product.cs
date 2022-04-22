using System;
using System.Collections.Generic;

namespace CQRSPattern.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int CategoryId { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int Stock { get; set; }

        public virtual Category Category { get; set; } = null!;
    }
}
