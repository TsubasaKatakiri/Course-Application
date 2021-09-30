using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Review
{
    public class ReviewCreate
    {
        private Guid Id { get; set; }

        public Guid UserId { get; set; }
        public string Username { get; set; }
        public int Score { get; set; }
        public string Text { get; set; }
        public Guid? ProductId { get; set; }
    }
}
