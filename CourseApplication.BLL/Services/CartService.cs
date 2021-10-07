using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.Cart;
using CourseApplication.BLL.VMs.OrderPosition;
using CourseApplication.DAL.Patterns;
using CourseApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Services
{
    public class CartService : ICartService
    {
        public CartService(IUnitOfWork db)
        {
            _db = db;
        }

        private readonly IUnitOfWork _db;

        public async Task<Guid> CreateCartAsync(Guid userId)
        {
            try
            {
                var cart = new Cart() {
                    UserId = userId
                };
                cart = await _db.Carts.CreateAsync(cart);

                return cart.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CartData FindCartById(Guid id)
        {
            try
            {
                var cart = _db.Carts.GetAll().Where(c => c.UserId == id).SingleOrDefault();
                return new CartData()
                {
                    CartId = cart.Id,
                    UserId = cart.UserId,
                    TotalCost = cart.PositionList.Sum(l => l.Product.Price * l.Number),
                    PositionList = cart.PositionList.Select(p =>
                    {
                        return new CartPositionData()
                        {
                            ProductId = (Guid)p.ProductId,
                            CartId = p.CartId,
                            Id = p.Id,
                            Name = p.Product.Name,
                            ShortDescription = p.Product.ShortDescription,
                            BrandName = p.Product.Brand.Name,
                            CategoryName = p.Product.Category.Name,
                            Price = p.Product.Price,
                            Number = p.Number,
                            TotalPrice = p.Product.Price * p.Number
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
