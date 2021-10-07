using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.WishlistPosition
{
    public class WishlistPositionCreate
    {
        public Guid ProductId { get; set; }
        public Guid WishlistId { get; set; }
    }
}
