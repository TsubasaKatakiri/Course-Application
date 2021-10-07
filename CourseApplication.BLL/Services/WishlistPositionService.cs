using CourseApplication.BLL.Interfaces;
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
    public class WishlistPositionService : IWishlistPositionService
    {
        public WishlistPositionService(IUnitOfWork db)
        {
            _db = db;
        }
        private readonly IUnitOfWork _db;

        public async Task<Guid> CreateWishlistPositionAsync(WishlistPositionCreate _position)
        {
            try
            {
                var position = new WishlistPosition()
                {
                    ProductId = _position.ProductId,
                    WishlistId = _position.WishlistId
                };
                position = await _db.WishlistPositions.CreateAsync(position);
                var product = _db.Products.GetAll().Where(p=>p.Id==position.ProductId).SingleOrDefault();
                product.WishlistNumber += 1;
                await _db.Products.UpdateAsync(product);
                return position.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Guid?> FindWishlistPositionByWishlistIdAsync(Guid WishlistId, Guid ProductId)
        {
            try
            {
                var position = _db.WishlistPositions.GetAll().Where(p => p.WishlistId == WishlistId && p.ProductId == ProductId).SingleOrDefault();
                if (position != null)
                {
                    return position.Id;
                }
                else return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteWishlistPositionAsync(Guid id)
        {
            try
            {
                var position = await _db.WishlistPositions.GetByIdAsync(id);
                if (position != null)
                {
                    var product = _db.Products.GetAll().Where(p => p.Id == position.ProductId).SingleOrDefault();
                    product.WishlistNumber -= 1;
                    await _db.Products.UpdateAsync(product);
                    await _db.WishlistPositions.DeleteAsync(position.Id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
