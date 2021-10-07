using CourseApplication.BLL.VMs.OrderPosition;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Cart
{
    public class CartCreate
    {
        public Guid UserId { get; set; }
        public List<CartPositionCreate> PositionList { get; set; }
    }
}
