using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.Product;
using CourseApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CourseApplication.Controllers
{
    public class ProductController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IProductService _productService;
        private readonly IBrandService _brandService;
        private readonly ICategoryService _categoryService;
        private readonly IWishlistService _wishlistService;
        private readonly IWishlistPositionService _wishlistPositionService;
        private readonly ICartService _cartService;
        private readonly ICartPositionService _cartPositionService;

        public ProductController(UserManager<User> userManager, IProductService productService,
            IBrandService brandService, ICategoryService categoryService, IWishlistService wishlistService,
             IWishlistPositionService wishlistPositionService, ICartService cartService,
             ICartPositionService cartPositionService)
        {
            _userManager = userManager;
            _productService = productService;
            _brandService = brandService;
            _categoryService = categoryService;
            _wishlistService = wishlistService;
            _wishlistPositionService = wishlistPositionService;
            _cartService = cartService;
            _cartPositionService = cartPositionService;
        }

        //Get all products
        [HttpGet]
        public ActionResult GetAllProducts()
        {

            var products = _productService.FindProduct(null);
            return View(products);
        }

        //[HttpGet]
        //public ActionResult GetAllProducts([FromForm] ProductSearch productSearch)
        //{
        //    var products = _productService.FindProductByConditions(productSearch);
        //    return View(products);
        //}

        //Get a product by its ID
        [HttpGet]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            var product = _productService.FindProduct(p => p.Id == id).SingleOrDefault();
            var userId = Guid.Parse(_userManager.GetUserId(User));
            var wishlist = _wishlistService.FindWishlistById(userId);
            var cart = _cartService.FindCartById(userId);
            Guid? wishlistPositionId = await _wishlistPositionService.FindWishlistPositionByWishlistIdAsync(wishlist.WishlistId, id);
            if(wishlistPositionId != null)
            {
                product.InWishlist = true;
                product.WishlistPositionId = wishlistPositionId;
            }
            Guid? cartPositionId = await _cartPositionService.FindCartPositionByCartIdAsync(cart.CartId, id);
            if (cartPositionId != null)
            {
                product.InCart = true;
                product.CartPositionId = cartPositionId;
            }
            return View(product);
        }


        //Creating new product (GET)
        [HttpGet]
        public ActionResult CreateNewProduct()
        {
            var categories = _categoryService.FindCategory(null);
            var brands = _brandService.FindBrand(null);
            return View(new ProductCreate() { BrandsList=brands, CategoryList=categories });
        }

        //Creating new product (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateNewProduct([FromForm] ProductCreate product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _productService.CreateProductAsync(product);
                    return RedirectToAction(nameof(GetAllProducts));
                }
                return View(product);
            }
            catch
            {
                return View();
            }
        }

        //Editing existing product (GET)
        [HttpGet]
        public ActionResult EditProduct(Guid id)
        {
            var product = _productService.FindProduct(p => p.Id == id).SingleOrDefault();
            var categories = _categoryService.FindCategory(null);
            product.CategoryList = categories;
            var brands = _brandService.FindBrand(null);
            product.BrandsList = brands;
            return View(product);
        }

        //Editing existing product (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProduct([FromForm] ProductData product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _productService.EditProductAsync(product);
                    return RedirectToAction(nameof(GetAllProducts));
                }
                return View(product);
            }
            catch
            {
                return View();
            }
        }

        //Deleting existing product (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            try
            {
                await _productService.DeleteProductAsync(id);
                return RedirectToAction(nameof(GetAllProducts));
            }
            catch
            {
                return View();
            }
        }
    }
}
