using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.UserDeliveryData
{
    public class UserDeliveryDataInfo
    {
        public Guid DataId { get; set; }

        public Guid UserId { get; set; }

        public string PostalIndex { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartments { get; set; }

        public string FullAddressString { get; set; }

        public string FullName { get; set; }

        public string Telephone { get; set; }
    }
}
