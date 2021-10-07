using CourseApplication.BLL.Interfaces;
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
    public class CartPositionService : ICartPositionService
    {
        public CartPositionService(IUnitOfWork db)
        {
            _db = db;
        }
        private readonly IUnitOfWork _db;

        public async Task<Guid> CreateCartPositionAsync(CartPositionCreate _position)
        {
            try
            {
                var position = new CartPosition()
                {
                    ProductId = _position.ProductId,
                    CartId = _position.CartId
                };

                if (_position.Number != 0)
                {
                    position.Number = _position.Number;
                }

                position = await _db.CartPositions.CreateAsync(position);
                return position.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteCartPositionAsync(Guid id)
        {
            try
            {
                var position = await _db.CartPositions.GetByIdAsync(id);
                if (position != null)
                {
                    await _db.CartPositions.DeleteAsync(position.Id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Guid?> FindCartPositionByCartIdAsync(Guid CartId, Guid ProductId)
        {
            try
            {
                var position = _db.CartPositions.GetAll().Where(p => p.CartId == CartId && p.ProductId == ProductId).SingleOrDefault();
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
    }
}
