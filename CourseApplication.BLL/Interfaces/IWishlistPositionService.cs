using CourseApplication.BLL.VMs.WishlistPosition;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Interfaces
{
    public interface IWishlistPositionService
    {
        Task<Guid> CreateWishlistPositionAsync(WishlistPositionCreate position);
        Task<Guid?> FindWishlistPositionByWishlistIdAsync(Guid WishlistId, Guid ProductId);
        Task DeleteWishlistPositionAsync(Guid id);
    }
}
