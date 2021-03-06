using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.Models
{
    public class Wishlist : BaseEntity
    {
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public virtual List<WishlistPosition> PositionList { get; set; } = new List<WishlistPosition>();
    }
}
