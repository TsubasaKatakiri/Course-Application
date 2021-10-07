using CourseApplication.BLL.VMs.OrderPosition;
using CourseApplication.BLL.VMs.UserDeliveryData;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Order
{
    public class OrderCreate
    {
        public Guid UserId { get; set; }

        public Guid UserDeliveryDataId { get; set; }

        public Guid CartId { get; set; }

        public virtual List<OrderPositionData> PositionList { get; set; } = new List<OrderPositionData>();

        public List<UserDeliveryDataInfo> UserDeliveryDataList { get; set; } = new List<UserDeliveryDataInfo>();
    }
}
