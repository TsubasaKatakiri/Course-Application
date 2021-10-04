using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.OrderPosition
{
    public class OrderPositionCreate
    {
        public Guid ProductId { get; set; }
        public int Number { get; set; }
        public Guid CartId { get; set; }
    }
}
