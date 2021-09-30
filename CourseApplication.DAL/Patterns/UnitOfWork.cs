using CourseApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.DAL.Patterns
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _db;

        private IRepository<Models.Action> _actions;
        private IRepository<Brand> _brands;
        private IRepository<Cart> _carts;
        private IRepository<Category> _categories;
        private IRepository<Order> _orders;
        private IRepository<OrderPosition> _orderPositions;
        private IRepository<Product> _products;
        private IRepository<Review> _reviews;
        private IRepository<Wishlist> _wishlists;

        private bool _disposed = false;

        public UnitOfWork(AppDBContext db)
        {
            _db = db;
        }

        public IRepository<Models.Action> Actions => _actions ??= new Repository<Models.Action>(_db);
        public IRepository<Brand> Brands => _brands ??= new Repository<Brand>(_db);
        public IRepository<Cart> Carts => _carts ??= new Repository<Cart>(_db);
        public IRepository<Category> Categories => _categories ??= new Repository<Category>(_db);
        public IRepository<Order> Orders => _orders ??= new Repository<Order>(_db);
        public IRepository<OrderPosition> OrderPositions => _orderPositions ??= new Repository<OrderPosition>(_db);
        public IRepository<Product> Products => _products ??= new Repository<Product>(_db);
        public IRepository<Review> Reviews => _reviews ??= new Repository<Review>(_db);
        public IRepository<Wishlist> Wishlists => _wishlists ??= new Repository<Wishlist>(_db);

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public virtual void Dispose(bool disposing)
        {
            if (this._disposed)
            {
                return;
            }
            if (disposing)
            {
                _db.Dispose();
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
