using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.Order;
using CourseApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CourseApplication.Controllers
{
    public class OrderController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IOrderService _orderService;
        private readonly IUserDeliveryDataService _userDeliveryDataService;
        private readonly ICartService _cartService;

        public OrderController(UserManager<User> userManager, IOrderService orderService,
            IUserDeliveryDataService userDeliveryDataService, ICartService cartService)
        {
            _userManager = userManager;
            _orderService = orderService;
            _userDeliveryDataService = userDeliveryDataService;
            _cartService = cartService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult GetAllOrders()
        {
            var orders = _orderService.FindOrder(null).OrderByDescending(o=>o.DateCreated);
            return View(orders);
        }

        [HttpGet]
        [Authorize]
        public ActionResult GetAllUserOrders()
        {
            var userId = Guid.Parse(_userManager.GetUserId(User));
            var orders = _orderService.FindOrder(o=>o.UserId == userId).OrderByDescending(o => o.DateCreated);
            return View(orders);
        }

        [HttpGet]
        [Authorize]
        public ActionResult GetUserOrderById(Guid id)
        {
            var userId = Guid.Parse(_userManager.GetUserId(User));
            var order = _orderService.FindOrder(o => o.Id == id && o.UserId == userId).SingleOrDefault();
            return View(order);
        }

        [HttpGet]
        [Authorize]
        public ActionResult CreateNewOrder()
        {
            var userId = Guid.Parse(_userManager.GetUserId(User));
            var userDeliveryData = _userDeliveryDataService.FindUserDeliveryData(d=>d.UserId == userId);
            var cart = _cartService.FindCartById(userId);
            return View(new OrderCreate() { UserId = userId, CartId = cart.CartId, UserDeliveryDataList = userDeliveryData });
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateNewOrder([FromForm] OrderCreate order)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _orderService.CreateOrderAsync(order);
                    return RedirectToAction(nameof(GetAllUserOrders));
                }
                return View(order);
            }
            catch
            {
                return View();
            }
        }
    }
}
