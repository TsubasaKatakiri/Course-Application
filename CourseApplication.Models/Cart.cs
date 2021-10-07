using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.Models
{
    public class Cart : BaseEntity
    {
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public virtual List<CartPosition> PositionList { get; set; } = new List<CartPosition>();
    }
}
