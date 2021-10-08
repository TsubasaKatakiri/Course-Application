using CourseApplication.BLL.VMs.Files;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Review
{
    public class ReviewData
    {
        public Guid ReviewId { get; set; }
        public Guid? ProductId { get; set; }

        public DateTime DateCreated { get; set; }
        public string Username { get; set; }
        public int Score { get; set; }
        public string Text { get; set; }
        public string ProductName { get; set; }

        public List<FileCreate> Files { get; set; } = new List<FileCreate>();
    }
}
