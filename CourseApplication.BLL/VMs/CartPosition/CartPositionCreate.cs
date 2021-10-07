using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.OrderPosition
{
    public class CartPositionCreate
    {
        public Guid ProductId { get; set; }
        public int Number { get; set; } = 1;
        public Guid CartId { get; set; }
    }
}
