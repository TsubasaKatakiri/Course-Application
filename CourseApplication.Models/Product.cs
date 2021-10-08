using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CourseApplication.Models
{
    public class Product : MediaEntity
    {
        [Required]
        public string Name { get; set; }

        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Guid BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        public double Score { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }

        //public Guid ActionId { get; set; }
        //public virtual Action Action { get; set; }

        public int OrderNumber { get; set; }
        public int WishlistNumber { get; set; }

        public virtual List<Review> Reviews { get; set; } = new List<Review>();
    }
}
