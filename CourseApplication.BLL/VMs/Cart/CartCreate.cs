using CourseApplication.BLL.VMs.OrderPosition;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Cart
{
    public class CartCreate
    {
        public List<OrderPositionCreate> PositionList { get; set; }
    }
}
