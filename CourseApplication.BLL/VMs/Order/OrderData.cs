using CourseApplication.BLL.VMs.OrderPosition;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Order
{
    public class OrderData
    {
        public Guid OrderId { get; set; }

        public DateTime DateCreated { get; set; }

        public string PostalIndex { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartments { get; set; }

        public string FullName { get; set; }

        public string Telephone { get; set; }

        public decimal TotalCost { get; set; }

        public Guid CartId { get; set; }
        public List<OrderPositionData> PositionList { get; set; } = new List<OrderPositionData>();
    }
}
