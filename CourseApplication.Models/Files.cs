using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.Models
{
    public class Files : BaseEntity
    {
        public Guid? MediaEntityId { get; set; }
        public virtual MediaEntity MediaEntity { get; set; }

        public string Name { get; set; }

        public string FileType { get; set; }

        public byte[] DataFiles { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
