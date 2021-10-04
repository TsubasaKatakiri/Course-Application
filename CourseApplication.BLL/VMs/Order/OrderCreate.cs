using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Order
{
    public class OrderCreate
    {
        public Guid UserId { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }

        public Guid CartId { get; set; }
    }
}
