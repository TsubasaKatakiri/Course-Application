using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.Wishlist;
using CourseApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CourseApplication.Controllers
{
    public class WishlistController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IWishlistService _wishlistService;

        public WishlistController(UserManager<User> userManager, IWishlistService wishlistService)
        {
            _userManager = userManager;
            _wishlistService = wishlistService;
        }

        [HttpGet]
        [Authorize]
        public ActionResult GetWishlistById()
        {
            var userId = Guid.Parse(_userManager.GetUserId(User));
            var wishlist = _wishlistService.FindWishlistById(userId);
            return View(wishlist);
        }
    }
}
