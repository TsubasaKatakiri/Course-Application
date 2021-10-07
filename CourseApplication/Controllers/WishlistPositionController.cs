using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.OrderPosition;
using CourseApplication.BLL.VMs.WishlistPosition;
using CourseApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CourseApplication.Controllers
{
    public class WishlistPositionController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IWishlistPositionService _wishlistPositionService;
        private readonly IWishlistService _wishlistService;

        public WishlistPositionController(UserManager<User> userManager, IWishlistPositionService wishlistPositionService,
            IWishlistService wishlistService)
        {
            _userManager = userManager;
            _wishlistPositionService = wishlistPositionService;
            _wishlistService = wishlistService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateWishlistPosition(Guid productId)
        {
            try
            {
                var userId = Guid.Parse(_userManager.GetUserId(User));
                var wishlist = _wishlistService.FindWishlistById(userId);
                if (ModelState.IsValid)
                {
                    var wishlistPosition = new WishlistPositionCreate()
                    {
                        ProductId = productId,
                        WishlistId = wishlist.WishlistId
                    };
                    await _wishlistPositionService.CreateWishlistPositionAsync(wishlistPosition);
                    return RedirectToRoute("default", new { controller = "Wishlist", action = "GetWishlistById" });
                }
                return View(wishlist);
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteWishlistPosition(Guid positionId)
        {
            try
            {
                var userId = Guid.Parse(_userManager.GetUserId(User));
                var wishlist = _wishlistService.FindWishlistById(userId);
                if (ModelState.IsValid)
                {
                    await _wishlistPositionService.DeleteWishlistPositionAsync(positionId);
                    return RedirectToRoute("default", new { controller = "Wishlist", action = "GetWishlistById" });
                }
                return View(wishlist);
            }
            catch
            {
                return View();
            }
        }
    }
}
