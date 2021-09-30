using CourseApplication.BLL.VMs.Review;
using CourseApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Interfaces
{
    public interface IReviewService
    {
        Task<Guid> CreateReviewAsync(ReviewCreate review);
        List<ReviewData> FindReview(Func<Review, bool> expression);
        Task<Guid> EditReviewAsync(ReviewData review);
        Task DeleteReviewAsync(Guid id);
    }
}
