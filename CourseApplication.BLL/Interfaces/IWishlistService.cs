using CourseApplication.BLL.VMs.Wishlist;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Interfaces
{
    public interface IWishlistService
    {
        Task<Guid> CreateWishlistAsync(Guid userId);
        WishlistData FindWishlistById(Guid id);
    }
}
