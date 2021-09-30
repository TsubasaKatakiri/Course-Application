using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.Category;
using CourseApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CourseApplication.Controllers
{
    public class CategoryController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ICategoryService _categoryService;

        public CategoryController(UserManager<User> userManager, ICategoryService categoryService)
        {
            _userManager = userManager;
            _categoryService = categoryService;
        }

        //Get all categories
        [HttpGet]
        public ActionResult GetAllCategories()
        {
            var categories = _categoryService.FindCategory(null);
            return View(categories);
        }

        //Get a category by its ID
        [HttpGet]
        public ActionResult GetCategoryById(Guid id)
        {
            var category = _categoryService.FindCategory(p => p.Id == id).SingleOrDefault();
            return View(category);
        }

        //Creating new category (GET)
        [HttpGet]
        public ActionResult CreateNewCategory()
        {
            return View(new CategoryCreate());
        }

        //Creating new category (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCategory([FromForm] CategoryCreate category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _categoryService.CreateCategoryAsync(category);
                    //return RedirectToAction(nameof(GetAllCategories));
                    return RedirectToRoute("default", new { controller = "Product", action = "GetAllProducts" });
                }
                return View(category);
            }
            catch
            {
                return View();
            }
        }

        //Editing existing category (GET)
        [HttpGet]
        public ActionResult EditCategory(Guid id)
        {
            var category = _categoryService.FindCategory(p => p.Id == id).SingleOrDefault();
            return View(category);
        }

        //Editing existing category (PUT)
        [HttpPut]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCategory([FromForm] CategoryData category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _categoryService.EditCategoryAsync(category);
                    return RedirectToAction(nameof(GetAllCategories));
                }
                return View(category);
            }
            catch
            {
                return View();
            }
        }

        //Deleting existing category (DELETE)
        [HttpDelete]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            try
            {
                await _categoryService.DeleteCategoryAsync(id);
                return RedirectToAction(nameof(GetAllCategories));
            }
            catch
            {
                return View();
            }
        }
    }
}
