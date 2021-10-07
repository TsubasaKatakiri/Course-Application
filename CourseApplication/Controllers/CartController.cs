using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.Cart;
using CourseApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CourseApplication.Controllers
{
    public class CartController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ICartService _cartService;

        public CartController(UserManager<User> userManager, ICartService cartService)
        {
            _userManager = userManager;
            _cartService = cartService;
        }

        [HttpGet]
        public ActionResult GetCartById()
        {
            var userId = Guid.Parse(_userManager.GetUserId(User));
            var cart = _cartService.FindCartById(userId);
            return View(cart);
        }
    }
}
