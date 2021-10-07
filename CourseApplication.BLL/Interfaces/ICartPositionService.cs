using CourseApplication.BLL.VMs.OrderPosition;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Interfaces
{
    public interface ICartPositionService
    {
        Task<Guid> CreateCartPositionAsync(CartPositionCreate position);
        Task<Guid?> FindCartPositionByCartIdAsync(Guid CartId, Guid ProductId);
        Task DeleteCartPositionAsync(Guid id);
    }
}
