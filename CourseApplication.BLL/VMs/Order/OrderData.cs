using CourseApplication.BLL.VMs.OrderPosition;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Order
{
    public class OrderData
    {
        public DateTime DateCreated { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }

        public decimal TotalCost { get; set; }

        public Guid CartId { get; set; }
        public List<OrderPositionData> PositionList { get; set; } = new List<OrderPositionData>();
    }
}
