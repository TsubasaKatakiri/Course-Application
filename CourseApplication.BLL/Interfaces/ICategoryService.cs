using CourseApplication.BLL.VMs.Category;
using CourseApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Interfaces
{
    public interface ICategoryService
    {
        Task<Guid> CreateCategoryAsync(CategoryCreate category);
        List<CategoryData> FindCategory(Func<Category, bool> expression);
        Task<Guid> EditCategoryAsync(CategoryData category);
        Task DeleteCategoryAsync(Guid id);
    }
}
