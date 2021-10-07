using CourseApplication.BLL.VMs.Product;
using CourseApplication.BLL.VMs.WishlistPosition;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Wishlist
{
    public class WishlistData
    {
        public Guid WishlistId { get; set; }
        public Guid UserId { get; set; }
        public List<WishlistPositionData> ProductList { get; set; }
    }
}
