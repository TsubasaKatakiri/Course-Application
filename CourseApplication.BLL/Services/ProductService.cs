using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.Files;
using CourseApplication.BLL.VMs.Product;
using CourseApplication.BLL.VMs.Review;
using CourseApplication.DAL.Patterns;
using CourseApplication.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Services
{
    public class ProductService : IProductService
    {
        public ProductService(IUnitOfWork db)
        {
            _db = db;
        }

        private readonly IUnitOfWork _db;

        public async Task<Guid> CreateProductAsync(ProductCreate _product)
        {
            try
            {
                var product = new Product()
                {
                    Name = _product.Name,
                    CategoryId = _product.CategoryId,
                    BrandId = _product.BrandId,
                    ShortDescription = _product.ShortDescription,
                    LongDescription = _product.LongDescription,
                    Score = 0,
                    Quantity = _product.Quantity,
                    Price = _product.Price,
                    OrderNumber = 0,
                    WishlistNumber = 0,
                };
                product = await _db.Products.CreateAsync(product);

                //file save to database
                if (_product.Files != null && _product.Files.Any())
                {
                    var files = _product.Files.ToList();
                    foreach(var item in files)
                    {
                        var file = new Files()
                        {
                            MediaEntityId = product.Id,
                            Name = Path.GetFileName(item.FileName),
                            FileType = Path.GetExtension(item.FileName),
                            CreatedOn = DateTime.Now
                        };

                        using (var target = new MemoryStream())
                        {
                            item.CopyTo(target);
                            file.DataFiles = target.ToArray();
                        }
                        file = await _db.Files.CreateAsync(file);
                    }
                }
                return product.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteProductAsync(Guid id)
        {
            try
            {
                await _db.Products.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Guid> EditProductAsync(ProductData _product)
        {
            try
            {
                var product = await _db.Products.GetByIdAsync(_product.ProductId);
                product.Name = _product.Name;
                product.CategoryId = _product.CategoryId;
                product.BrandId = _product.BrandId;
                product.ShortDescription = _product.ShortDescription;
                product.LongDescription = _product.LongDescription;
                product.Quantity = _product.Quantity;
                product.Price = _product.Price;
                await _db.Products.UpdateAsync(product);
                return product.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProductData> FindProduct(Func<Product, bool> expression)
        {
            try
            {
                List<Product> products;
                if (expression == null)
                {
                    products = _db.Products.GetAll().ToList();
                }
                else
                {
                    products = _db.Products.GetAll().Where(expression).ToList();
                }
                return products.Select(p =>
                {
                    return new ProductData()
                    {
                        ProductId = p.Id,
                        Name = p.Name,
                        CategoryId = p.CategoryId,
                        CategoryName = p.Category.Name,
                        BrandId = p.BrandId,
                        BrandName = p.Brand.Name,
                        ShortDescription = p.ShortDescription,
                        LongDescription = p.LongDescription,
                        Score = p.Score,
                        Quantity = p.Quantity,
                        Price = p.Price,
                        OrderNumber = p.OrderNumber,
                        WishlistNumber = p.WishlistNumber,
                        Files = p.Files.Select(f =>
                        {
                            return new FileCreate()
                            {
                                EntityId = f.MediaEntityId,
                                Name = f.Name,
                                FileType =f.FileType,
                                DataFiles = f.DataFiles,
                                CreatedOn = f.CreatedOn
                            };
                        }).ToList(),
                        Reviews = p.Reviews.Select(r =>
                        {
                            return new ReviewData()
                            {
                                ReviewId = r.Id,
                                ProductId = r.ProductId,
                                DateCreated = r.DateCreated,
                                //Username = r.User.UserName,
                                Score = r.Score,
                                Text = r.Text,
                                ProductName = r.Product.Name,
                            };
                        }).OrderByDescending(o => o.DateCreated).ToList()
                    };
                }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProductData> FindProductByConditions(ProductSearch productSearch)
        {
            try
            {
                List<Product> products;
                Func<Product, bool> whereFunction = p => (productSearch.ProductName != null ? p.Name.ToLower().Contains(productSearch.ProductName.ToLower()) : p.Name.Contains(""))
                    && (productSearch.CategoryName != null ? p.Category.Name == productSearch.CategoryName : p.Category.Name == null)
                    && (productSearch.BrandName != null ? p.Brand.Name == productSearch.BrandName : p.Brand.Name == null)
                    && (productSearch.PriceMin != 0.0M ? p.Price >= productSearch.PriceMin : p.Price >= 0.0M)
                    && (productSearch.PriceMax != 0.0M ? p.Price <= productSearch.PriceMax : p.Price <= Decimal.MaxValue)
                    && (productSearch.ScoreMin != 0.0 ? p.Score >= productSearch.ScoreMin : p.Score >= 0)
                    && (productSearch.ScoreMax != 0.0 ? p.Score <= productSearch.ScoreMax : p.Score <= 5);
                Func<Product, dynamic> orderFunction;
                if (productSearch.SortBy == "Name")
                {
                    orderFunction = p => p.Name;
                }
                else if (productSearch.SortBy == "Price")
                {
                    orderFunction = p => p.Price;
                }
                else if (productSearch.SortBy == "Orders")
                {
                    orderFunction = p => p.OrderNumber;
                }
                else if (productSearch.SortBy == "Score")
                {
                    orderFunction = p => p.Score;
                }
                else
                {
                    orderFunction = p => p.Id;
                }
                if (productSearch.IsBackwardsSorting == false)
                {
                    products = _db.Products.GetAll().Where(whereFunction).OrderBy(orderFunction).ToList();
                }
                else
                {
                    products = _db.Products.GetAll().Where(whereFunction).OrderByDescending(orderFunction).ToList();
                }
                return products.Select(p =>
                {
                    return new ProductData()
                    {
                        ProductId = p.Id,
                        Name = p.Name,
                        CategoryId = p.CategoryId,
                        CategoryName = p.Category.Name,
                        BrandId = p.BrandId,
                        BrandName = p.Brand.Name,
                        ShortDescription = p.ShortDescription,
                        LongDescription = p.LongDescription,
                        Score = p.Score,
                        Quantity = p.Quantity,
                        Price = p.Price,
                        //ActionId = p.ActionId,
                        OrderNumber = p.OrderNumber,
                        WishlistNumber = p.WishlistNumber,
                        Reviews = p.Reviews.Select(r =>
                        {
                            return new ReviewData()
                            {
                                ReviewId = r.Id,
                                ProductId = r.ProductId,
                                DateCreated = r.DateCreated,
                                //Username = r.User.UserName,
                                Score = r.Score,
                                Text = r.Text,
                                ProductName = r.Product.Name,
                            };
                        }).OrderByDescending(o => o.DateCreated).ToList()
                    };
                }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
