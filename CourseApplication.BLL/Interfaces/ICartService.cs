using CourseApplication.BLL.VMs.Cart;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Interfaces
{
    public interface ICartService
    {
        Task<Guid> CreateCartAsync();
        List<CartData> FindCartById(Guid id);
    }
}
