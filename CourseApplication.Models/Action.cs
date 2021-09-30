using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.Models
{
    public class Action : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Discount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }

        public virtual List<Product> ProductList { get; set; } = new List<Product>();
    }
}
