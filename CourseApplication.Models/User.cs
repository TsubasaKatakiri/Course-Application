using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public Guid CartId { get; set; }

        public Guid WishlistId { get; set; }
    }
}
