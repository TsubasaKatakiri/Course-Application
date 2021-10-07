using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.OrderPosition;
using CourseApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CourseApplication.Controllers
{
    public class CartPositionController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ICartPositionService _cartPositionService;
        private readonly ICartService _cartService;

        public CartPositionController(UserManager<User> userManager, ICartPositionService cartPositionService,
            ICartService cartService)
        {
            _userManager = userManager;
            _cartPositionService = cartPositionService;
            _cartService = cartService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCartPosition(Guid productId)
        {
            try
            {
                var userId = Guid.Parse(_userManager.GetUserId(User));
                var cart = _cartService.FindCartById(userId);
                if (ModelState.IsValid)
                {
                    var cartPosition = new CartPositionCreate()
                    {
                        ProductId = productId,
                        CartId = cart.CartId
                    };
                    await _cartPositionService.CreateCartPositionAsync(cartPosition);
                    return RedirectToRoute("default", new { controller = "Cart", action = "GetCartById" });
                }
                return View(cart);
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCartPosition(Guid positionId)
        {
            try
            {
                var userId = Guid.Parse(_userManager.GetUserId(User));
                var cart = _cartService.FindCartById(userId);
                if (ModelState.IsValid)
                {
                    await _cartPositionService.DeleteCartPositionAsync(positionId);
                    return RedirectToRoute("default", new { controller = "Cart", action = "GetCartById" });
                }
                return View(cart);
            }
            catch
            {
                return View();
            }
        }
    }
}
