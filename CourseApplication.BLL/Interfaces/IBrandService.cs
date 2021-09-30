using CourseApplication.BLL.VMs.Brand;
using CourseApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Interfaces
{
    public interface IBrandService
    {
        Task<Guid> CreateBrandAsync(BrandCreate brand);
        List<BrandData> FindBrand(Func<Brand, bool> expression);
        Task<Guid> EditBrandAsync(BrandData brand);
        Task DeleteBrandAsync(Guid id);
    }
}
