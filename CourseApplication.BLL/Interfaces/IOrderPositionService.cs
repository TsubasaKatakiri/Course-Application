using CourseApplication.BLL.VMs.OrderPosition;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Interfaces
{
    public interface IOrderPositionService
    {
        Task<Guid> CreateOrderPositionAsync(OrderPositionCreate orderPositionCreate);
        Task<Guid?> FindOrderPositionByOrderIdAsync(Guid OrderId, Guid ProductId);
        Task DeleteOrderPositionAsync(Guid id);
    }
}
