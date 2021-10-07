using CourseApplication.BLL.VMs.Product;
using CourseApplication.BLL.VMs.WishlistPosition;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Wishlist
{
    public class WishlistCreate
    {
        public Guid UserId { get; set; }
        public List<WishlistPositionData> Products { get; set; }
    }
}
