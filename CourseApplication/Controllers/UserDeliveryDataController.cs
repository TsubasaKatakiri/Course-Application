using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.UserDeliveryData;
using CourseApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CourseApplication.Controllers
{
    public class UserDeliveryDataController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IUserDeliveryDataService _userDeliveryDataService;

        public UserDeliveryDataController(UserManager<User> userManager, IUserDeliveryDataService userDeliveryDataService)
        {
            _userManager = userManager;
            _userDeliveryDataService = userDeliveryDataService;
        }

        [HttpGet]
        [Authorize]
        public ActionResult GetAllUserDeliveryData()
        {
            var userId = Guid.Parse(_userManager.GetUserId(User));
            var userDeliveryData = _userDeliveryDataService.FindUserDeliveryData(d=>d.UserId == userId);
            return View(userDeliveryData);
        }

        [HttpGet]
        [Authorize]
        public ActionResult GetUserDeliveryDataById(Guid id)
        {
            var userId = Guid.Parse(_userManager.GetUserId(User));
            var userDeliveryData = _userDeliveryDataService.FindUserDeliveryData(d => d.UserId == userId && d.Id == id).SingleOrDefault();
            return View(userDeliveryData);
        }

        [HttpGet]
        [Authorize]
        public ActionResult CreateUserDeliveryData()
        {
            var userId = Guid.Parse(_userManager.GetUserId(User));
            return View(new UserDeliveryDataCreate() { UserId = userId });
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUserDeliveryData([FromForm] UserDeliveryDataCreate userDeliveryData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _userDeliveryDataService.CreateUserDeliveryDataAsync(userDeliveryData);
                    return RedirectToAction(nameof(GetAllUserDeliveryData));
                }
                return View(userDeliveryData);
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        [Authorize]
        public ActionResult EditUserDeliveryData(Guid id)
        {
            var userId = Guid.Parse(_userManager.GetUserId(User));
            var userDeliveryData = _userDeliveryDataService.FindUserDeliveryData(d => d.UserId == userId && d.Id == id).SingleOrDefault();
            return View(userDeliveryData);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUserDeliveryData([FromForm] UserDeliveryDataInfo userDeliveryData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _userDeliveryDataService.EditUserDeliveryDataAsync(userDeliveryData);
                    return RedirectToAction(nameof(GetAllUserDeliveryData));
                }
                return View(userDeliveryData);
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUserDeliveryData(Guid id)
        {
            try
            {
                await _userDeliveryDataService.DeleteUserDeliveryDataAsync(id);
                return RedirectToAction(nameof(GetAllUserDeliveryData));
            }
            catch
            {
                return View();
            }
        }
    }
}
