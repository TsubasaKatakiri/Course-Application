using CourseApplication.BLL.VMs.OrderPosition;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Cart
{
    public class CartData
    {
        public Guid CartId { get; set; }
        public Guid UserId { get; set; }
        public decimal TotalCost { get; set; }
        public List<CartPositionData> PositionList { get; set; } = new List<CartPositionData>();
    }
}
