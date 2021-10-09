using CourseApplication.BLL.Interfaces;
using CourseApplication.DAL.Patterns;
using CourseApplication.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Utility
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, 
            IWishlistService wishlistService, ICartService cartService)
        {
            string adminEmail = "admin@test.test";
            string adminName = "admin";
            string password = "Qwerty1!";
            if (await roleManager.FindByNameAsync("Admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }
            if (await roleManager.FindByNameAsync("User") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("User"));
            }
            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                User admin = new User { Email = adminEmail, UserName = adminEmail, Name = adminName };
                IdentityResult result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "Admin");
                    await userManager.AddToRoleAsync(admin, "User");
                    var userId = Guid.Parse(admin.Id);
                    await cartService.CreateCartAsync(userId);
                    await wishlistService.CreateWishlistAsync(userId);
                }
            }
        }
    }
}
