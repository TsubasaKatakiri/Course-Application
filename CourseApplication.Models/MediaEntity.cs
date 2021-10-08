using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.Models
{
    public class MediaEntity : BaseEntity
    {
        public virtual List<Files> Files { get; set; } = new List<Files>();
    }
}
