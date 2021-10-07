using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.WishlistPosition
{
    public class WishlistPositionData
    {
        public Guid ProductId { get; set; }
        public Guid WishlistId { get; set; }
        public Guid WishlistPositionId { get; set; }

        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string BrandName { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
    }
}
