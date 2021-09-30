using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.Review;
using CourseApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CourseApplication.Controllers
{
    public class ReviewController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IReviewService _reviewService;

        public ReviewController(UserManager<User> userManager, IReviewService reviewService)
        {
            _userManager = userManager;
            _reviewService = reviewService;
        }

        //Creating new review (GET)
        [HttpGet]
        [Authorize]
        public ActionResult CreateReview(Guid id)
        {
            return View(new ReviewCreate() { ProductId = id });
        }

        //Creating new review (POST)
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateReview([FromForm] ReviewCreate review)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var currentUser = _userManager.GetUserAsync(User).Result;
                    review.UserId = new Guid(currentUser.Id);

                    await _reviewService.CreateReviewAsync(review);

                    return RedirectToRoute("default", new { controller = "Product", action = "GetProductById", id = review.ProductId });
                }
                return View(review);
            }
            catch
            {
                return View();
            }
        }

        //Editing existing product (GET)
        [HttpGet]
        public ActionResult EditReview(Guid id)
        {
            var review = _reviewService.FindReview(p => p.Id == id).SingleOrDefault();
            return View(review);
        }


        //Editing existing product (PUT)
        [HttpPut]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditReview([FromForm] ReviewData review)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _reviewService.EditReviewAsync(review);
                    return RedirectToRoute("default", new { controller = "Product", action = "GetProductById", id = review.ProductId });
                }
                return View(review);
            }
            catch
            {
                return View();
            }
        }

        ////Deleting existing review (DELETE)
        //[HttpDelete]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteProduct(Guid id)
        //{
        //    try
        //    {
        //        await _reviewService.DeleteReviewAsync(id);
        //        return RedirectToRoute("default", new { controller = "Product", action = "GetProductById", id = review.ProductId });
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
