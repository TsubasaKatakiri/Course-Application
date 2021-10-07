using CourseApplication.BLL.VMs.UserDeliveryData;
using CourseApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Interfaces
{
    public interface IUserDeliveryDataService
    {
        Task<Guid> CreateUserDeliveryDataAsync(UserDeliveryDataCreate userDeliveryData);
        List<UserDeliveryDataInfo> FindUserDeliveryData(Func<UserDeliveryData, bool> expression);
        Task<Guid> EditUserDeliveryDataAsync(UserDeliveryDataInfo userDeliveryData);
        Task DeleteUserDeliveryDataAsync(Guid id);
    }
}
