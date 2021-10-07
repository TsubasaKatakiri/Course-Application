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
    public class OrderPositionService : IOrderPositionService
    {
        public OrderPositionService(IUnitOfWork db)
        {
            _db = db;
        }
        private readonly IUnitOfWork _db;

        public async Task<Guid> CreateOrderPositionAsync(OrderPositionCreate _position)
        {
            try
            {
                var position = new OrderPosition()
                {
                    ProductId = _position.ProductId,
                    OrderId = _position.OrderId
                };

                if (_position.Number != 0)
                {
                    position.Number = _position.Number;
                }

                position = await _db.OrderPositions.CreateAsync(position);
                return position.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteOrderPositionAsync(Guid id)
        {
            try
            {
                var position = await _db.OrderPositions.GetByIdAsync(id);
                if (position != null)
                {
                    await _db.OrderPositions.DeleteAsync(position.Id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Guid?> FindOrderPositionByOrderIdAsync(Guid OrderId, Guid ProductId)
        {
            try
            {
                var position = _db.OrderPositions.GetAll().Where(p => p.OrderId == OrderId && p.ProductId == ProductId).SingleOrDefault();
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
