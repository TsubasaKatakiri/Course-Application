using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.Review;
using CourseApplication.DAL.Patterns;
using CourseApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Services
{
    public class ReviewService : IReviewService
    {
        public ReviewService(IUnitOfWork db, IProductService productService)
        {
            _db = db;
            _productService = productService;
        }

        private readonly IUnitOfWork _db;
        private readonly IProductService _productService;

        public async Task<Guid> CreateReviewAsync(ReviewCreate _review)
        {
            try
            {
                var review = new Review()
                {
                    UserId = _review.UserId,
                    ProductId = _review.ProductId,
                    DateCreated = DateTime.Now,
                    Score = _review.Score,
                    Text = _review.Text
                };
                review = await _db.Reviews.CreateAsync(review);
                await RecalculateProductScore(review.ProductId);
                return review.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task RecalculateProductScore(Guid? productId)
        {
            try
            {
                Guid productGuid = (Guid)productId;
                double reviewScore = _db.Reviews.GetAll().Where(r=>r.ProductId==productId).ToList().Sum(s=>s.Score);
                int reviewNumber = _db.Reviews.GetAll().Where(r => r.ProductId == productId).ToList().Count;
                double productScore = reviewScore / reviewNumber;
                var product = await _db.Products.GetByIdAsync(productGuid);
                product.Score = productScore;
                await _db.Products.UpdateAsync(product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteReviewAsync(Guid id)
        {
            try
            {
                var review = _db.Reviews.GetAll().Where(r => r.Id == id).SingleOrDefault();
                Guid? productId = review.ProductId;
                await _db.Reviews.DeleteAsync(id);
                await RecalculateProductScore(review.ProductId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Guid> EditReviewAsync(ReviewData _review)
        {
            try
            {
                var review = await _db.Reviews.GetByIdAsync(_review.ReviewId);
                review.Score = _review.Score;
                review.Text= _review.Text;
                await _db.Reviews.UpdateAsync(review);
                await RecalculateProductScore(review.ProductId);
                return review.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ReviewData> FindReview(Func<Review, bool> expression)
        {
            try
            {
                List<Review> reviews;
                if (expression == null)
                {
                    reviews = _db.Reviews.GetAll().ToList();
                }
                else
                {
                    reviews = _db.Reviews.GetAll().Where(expression).ToList();
                }
                return reviews.Select(r =>
                {
                    return new ReviewData()
                    {
                        ReviewId = r.Id,
                        ProductId = r.ProductId,
                        DateCreated = r.DateCreated,
                        Username = r.User.Name,
                        Score = r.Score,
                        Text = r.Text,
                        ProductName = r.Product.Name,
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
