using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.Order;
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
    public class OrderService : IOrderService
    {
        public OrderService(IUnitOfWork db, IOrderPositionService orderPositionService, ICartPositionService cartPositionService)
        {
            _db = db;
            _orderPositionService = orderPositionService;
            _cartPositionService = cartPositionService;
        }

        private readonly IUnitOfWork _db;
        private readonly IOrderPositionService _orderPositionService;
        private readonly ICartPositionService _cartPositionService;

        public async Task<Guid> CreateOrderAsync(OrderCreate _order)
        {
            try
            {
                var order = new Order()
                {
                    DateCreated = DateTime.Now,
                    UserId = _order.UserId,
                    UserDeliveryDataId = _order.UserDeliveryDataId,
                    CartId = _order.CartId
                };
                order = await _db.Orders.CreateAsync(order);

                //making order positions from cart positions
                var cartPositions = _db.CartPositions.GetAll().Where(p => p.CartId == order.CartId).ToList();
                foreach (var item in cartPositions)
                {
                    var orderPosition = new OrderPositionCreate()
                    {
                        ProductId = (Guid)item.ProductId,
                        Number = item.Number,
                        OrderId = order.Id
                    };
                    await _orderPositionService.CreateOrderPositionAsync(orderPosition);
                    var product = _db.Products.GetAll().Where(p => p.Id == item.ProductId).SingleOrDefault();
                    product.OrderNumber += item.Number;
                    product.Quantity -= item.Number;
                    await _db.Products.UpdateAsync(product);
                }

                //clearing user cart
                foreach (var item in cartPositions)
                {
                    await _cartPositionService.DeleteCartPositionAsync(item.Id);
                }

                return order.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<OrderData> FindOrder(Func<Order, bool> expression)
        {
            try
            {
                List<Order> orders;
                if (expression == null)
                {
                    orders = _db.Orders.GetAll().ToList();
                }
                else
                {
                    orders = _db.Orders.GetAll().Where(expression).ToList();
                }
                return orders.Select(o =>
                {
                    return new OrderData()
                    {
                        OrderId = o.Id,
                        DateCreated = o.DateCreated,
                        CartId = o.CartId,
                        PostalIndex = o.UserDeliveryData.PostalIndex,
                        Country = o.UserDeliveryData.Country,
                        Region = o.UserDeliveryData.Region,
                        City = o.UserDeliveryData.City,
                        Street = o.UserDeliveryData.Street,
                        House = o.UserDeliveryData.House,
                        Apartments = o.UserDeliveryData.Apartments,
                        FullName = o.UserDeliveryData.FullName,
                        Telephone = o.UserDeliveryData.Telephone,
                        TotalCost = o.PositionList.Sum(l => l.Product.Price * l.Number),
                        PositionList = o.PositionList.Select(p =>
                        {
                            return new OrderPositionData()
                            {
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
                }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
