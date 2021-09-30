using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.Models
{
    public class Order : BaseEntity
    {
        public DateTime DateCreated { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public Guid CartId { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
