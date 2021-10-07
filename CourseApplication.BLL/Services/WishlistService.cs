using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.Product;
using CourseApplication.BLL.VMs.Review;
using CourseApplication.BLL.VMs.Wishlist;
using CourseApplication.BLL.VMs.WishlistPosition;
using CourseApplication.DAL.Patterns;
using CourseApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Services
{
    public class WishlistService : IWishlistService
    {
        public WishlistService(IUnitOfWork db)
        {
            _db = db;
        }

        private readonly IUnitOfWork _db;

        public async Task<Guid> CreateWishlistAsync(Guid userId)
        {
            try
            {
                var wishlist = new Wishlist() {
                    UserId = userId
                };
                wishlist = await _db.Wishlists.CreateAsync(wishlist);

                return wishlist.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public WishlistData FindWishlistById(Guid id)
        {
            try
            {
                var wishlist = _db.Wishlists.GetAll().Where(w => w.UserId == id).SingleOrDefault();
                return new WishlistData()
                {
                    WishlistId = wishlist.Id,
                    UserId = wishlist.UserId,
                    ProductList = wishlist.PositionList.Select(p =>
                    {
                        return new WishlistPositionData()
                        {
                            ProductId = p.ProductId,
                            WishlistId = p.WishlistId,
                            WishlistPositionId = p.Id,
                            Name = p.Product.Name,
                            ShortDescription = p.Product.ShortDescription,
                            BrandName = p.Product.Brand.Name,
                            CategoryName = p.Product.Category.Name,
                            Price = p.Product.Price
                        };
                    }).ToList()
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
