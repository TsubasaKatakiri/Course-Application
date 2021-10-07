using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Models;

namespace CourseApplication.DAL.Patterns
{
    public interface IUnitOfWork
    {
        IRepository<Models.Action> Actions { get; }
        IRepository<Brand> Brands { get; }
        IRepository<Cart> Carts { get; }
        IRepository<Category> Categories { get; }
        IRepository<Order> Orders { get; }
        IRepository<CartPosition> CartPositions { get; }
        IRepository<OrderPosition> OrderPositions { get; }
        IRepository<Product> Products { get; }
        IRepository<Review> Reviews { get; }
        IRepository<UserDeliveryData> UserDeliveryData { get; }
        IRepository<Wishlist> Wishlists { get; }
        IRepository<WishlistPosition> WishlistPositions { get; }

        Task SaveAsync();
    }
}
