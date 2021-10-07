using CourseApplication.BLL.VMs.Order;
using CourseApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Interfaces
{
    public interface IOrderService
    {
        Task<Guid> CreateOrderAsync(OrderCreate order);
        List<OrderData> FindOrder(Func<Order, bool> expression);
    }
}
