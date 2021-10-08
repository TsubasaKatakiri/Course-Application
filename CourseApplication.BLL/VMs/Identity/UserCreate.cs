using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Identity
{
    public class UserCreate
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
