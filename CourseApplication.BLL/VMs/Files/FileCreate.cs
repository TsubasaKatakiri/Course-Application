using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Files
{
    public class FileCreate
    {
        public Guid? EntityId { get; set; }

        public string Name { get; set; }

        public string FileType { get; set; }

        public byte[] DataFiles { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
