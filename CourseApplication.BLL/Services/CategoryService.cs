using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.Category;
using CourseApplication.DAL.Patterns;
using CourseApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Services
{
    public class CategoryService : ICategoryService
    {
        public CategoryService(IUnitOfWork db)
        {
            _db = db;
        }

        private readonly IUnitOfWork _db;

        public async Task<Guid> CreateCategoryAsync(CategoryCreate _category)
        {
            try
            {
                var category = new Category()
                {
                    Name = _category.Name,

                };
                category = await _db.Categories.CreateAsync(category);
                return category.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteCategoryAsync(Guid id)
        {
            try
            {
                await _db.Categories.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Guid> EditCategoryAsync(CategoryData _category)
        {
            try
            {
                var category = await _db.Categories.GetByIdAsync(_category.Id);
                category.Name = _category.Name;
                await _db.Categories.UpdateAsync(category);
                return category.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CategoryData> FindCategory(Func<Category, bool> expression)
        {
            try
            {
                List<Category> categories;
                if (expression == null)
                {
                    categories = _db.Categories.GetAll().ToList();
                }
                else
                {
                    categories = _db.Categories.GetAll().Where(expression).ToList();
                }
                return categories.Select(c =>
                {
                    return new CategoryData()
                    {
                        Id=c.Id,
                        Name=c.Name,
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
