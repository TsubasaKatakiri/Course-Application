using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.Brand;
using CourseApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CourseApplication.Controllers
{
    public class BrandController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IBrandService _brandService;

        public BrandController(UserManager<User> userManager, IBrandService brandService)
        {
            _userManager = userManager;
            _brandService = brandService;
        }

        //Get all brands
        [HttpGet]
        [Authorize (Roles = "Admin")]
        public ActionResult GetAllBrands()
        {
            var brands = _brandService.FindBrand(null);
            return View(brands);
        }

        //Get a brand by its ID
        [HttpGet]
        [Authorize (Roles = "Admin")]
        public ActionResult GetBrandById(Guid id)
        {
            var brand = _brandService.FindBrand(p => p.Id == id).SingleOrDefault();
            return View(brand);
        }

        //Creating new brand (GET)
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult CreateNewBrand()
        {
            return View(new BrandCreate());
        }

        //Creating new brand (POST)
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBrand([FromForm] BrandCreate brand)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _brandService.CreateBrandAsync(brand);
                    //return RedirectToAction(nameof(GetAllBrands));
                    return RedirectToRoute("default", new { controller = "Product", action = "GetAllProducts" });
                }
                return View(brand);
            }
            catch
            {
                return View();
            }
        }

        //Editing existing brand (GET)
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult EditBrand(Guid id)
        {
            var brand = _brandService.FindBrand(p => p.Id == id).SingleOrDefault();
            return View(brand);
        }

        //Editing existing brand (POST)
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBrand([FromForm] BrandData brand)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _brandService.EditBrandAsync(brand);
                    return RedirectToAction(nameof(GetAllBrands));
                }
                return View(brand);
            }
            catch
            {
                return View();
            }
        }

        //Deleting existing brand (POST)
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteBrand(Guid id)
        {
            try
            {
                await _brandService.DeleteBrandAsync(id);
                return RedirectToAction(nameof(GetAllBrands));
            }
            catch
            {
                return View();
            }
        }
    }
}
