using CourseApplication.BLL.VMs.OrderPosition;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Cart
{
    public class CartData
    {
        public Guid CartId { get; set; }
        public decimal TotalCost { get; set; }
        public List<OrderPositionData> PositionList { get; set; } = new List<OrderPositionData>();
    }
}
