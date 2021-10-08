using CourseApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace CourseApplication.DAL
{
    public class AppDBContext : IdentityDbContext<User>
    {
        public DbSet<Models.Action> Actions { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartPosition> CartPositions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Files> Files { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPosition> OrderPositions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<UserDeliveryData> UserDeliveryData { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<WishlistPosition> WishlistPositions { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
