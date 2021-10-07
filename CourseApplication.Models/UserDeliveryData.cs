using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.Models
{
    public class UserDeliveryData : BaseEntity
    {
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public string PostalIndex { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartments { get; set; }

        public string FullName { get; set; }

        public string Telephone { get; set; }
    }
}
