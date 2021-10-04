using CourseApplication.BLL.VMs.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Wishlist
{
    public class WishlistData
    {
        public Guid WishlistId { get; set; }
        public List<ProductData> ProductList { get; set; }
    }
}
