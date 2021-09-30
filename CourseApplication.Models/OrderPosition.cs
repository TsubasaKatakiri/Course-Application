using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.Models
{
    public class OrderPosition : BaseEntity
    {
        public Guid? ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int Number { get; set; }

        public Guid CartId { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
