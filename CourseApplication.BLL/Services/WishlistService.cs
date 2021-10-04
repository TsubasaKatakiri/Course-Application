using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.Product;
using CourseApplication.BLL.VMs.Review;
using CourseApplication.BLL.VMs.Wishlist;
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

        public async Task<Guid> CreateWishlistAsync()
        {
            try
            {
                var wishlist = new Wishlist() { };
                wishlist = await _db.Wishlists.CreateAsync(wishlist);

                return wishlist.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<WishlistData> FindWishlistById(Guid id)
        {
            try
            {
                var wishlist = _db.Wishlists.GetAll().Where(w => w.Id == id).ToList();
                return wishlist.Select(c =>
                {
                    return new WishlistData()
                    {
                        WishlistId = c.Id,
                        ProductList = c.ProductList.Select(p =>
                        {
                            return new ProductData()
                            {
                                ProductId = p.Id,
                                Name = p.Name,
                                CategoryId = p.CategoryId,
                                CategoryName = p.Category.Name,
                                BrandId = p.BrandId,
                                BrandName = p.Brand.Name,
                                ShortDescription = p.ShortDescription,
                                LongDescription = p.LongDescription,
                                Score = p.Score,
                                Quantity = p.Quantity,
                                Price = p.Price,
                                //ActionId = p.ActionId,
                                OrderNumber = p.OrderNumber,
                                WishlistNumber = p.WishlistNumber,
                                Reviews = p.Reviews.Select(r =>
                                {
                                    return new ReviewData()
                                    {
                                        ReviewId = r.Id,
                                        ProductId = r.ProductId,
                                        DateCreated = r.DateCreated,
                                        //Username = r.User.UserName,
                                        Score = r.Score,
                                        Text = r.Text,
                                        ProductName = r.Product.Name,
                                    };
                                }).OrderByDescending(o => o.DateCreated).ToList()
                            };
                        }).ToList()
                    };
                }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
