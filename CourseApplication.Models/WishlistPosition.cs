using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.Models
{
    public class WishlistPosition : BaseEntity
    {
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }

        public Guid WishlistId { get; set; }
        public virtual Wishlist Wishlist { get; set; }
    }
}
