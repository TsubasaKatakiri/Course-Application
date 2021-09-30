using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.Brand;
using CourseApplication.DAL.Patterns;
using CourseApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Services
{
    public class BrandService : IBrandService
    {
        public BrandService(IUnitOfWork db)
        {
            _db = db;
        }

        private readonly IUnitOfWork _db;

        public async Task<Guid> CreateBrandAsync(BrandCreate _brand)
        {
            try
            {
                var brand = new Brand()
                {
                    Name = _brand.Name,

                };
                brand = await _db.Brands.CreateAsync(brand);
                return brand.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteBrandAsync(Guid id)
        {
            try
            {
                await _db.Brands.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Guid> EditBrandAsync(BrandData _brand)
        {
            try
            {
                var brand = await _db.Brands.GetByIdAsync(_brand.Id);
                brand.Name = _brand.Name;
                await _db.Brands.UpdateAsync(brand);
                return brand.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BrandData> FindBrand(Func<Brand, bool> expression)
        {
            try
            {
                List<Brand> brands;
                if (expression == null)
                {
                    brands = _db.Brands.GetAll().ToList();
                }
                else
                {
                    brands = _db.Brands.GetAll().Where(expression).ToList();
                }
                return brands.Select(c =>
                {
                    return new BrandData()
                    {
                        Id = c.Id,
                        Name = c.Name,
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
