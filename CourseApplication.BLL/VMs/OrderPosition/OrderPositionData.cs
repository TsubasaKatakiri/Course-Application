using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.OrderPosition
{
    public class OrderPositionData
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string BrandName { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public int Number { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
