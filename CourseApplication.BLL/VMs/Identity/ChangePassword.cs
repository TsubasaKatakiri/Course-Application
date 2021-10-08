using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Identity
{
    public class ChangePassword
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string NewPassword { get; set; }
        public string OldPassword { get; set; }
    }
}
