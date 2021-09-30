using CourseApplication.BLL.VMs.Product;
using CourseApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Interfaces
{
    public interface IProductService
    {
        Task<Guid> CreateProductAsync(ProductCreate product);
        List<ProductData> FindProduct(Func<Product, bool> expression);
        Task<Guid> EditProductAsync(ProductData product);
        Task DeleteProductAsync(Guid id);

        List<ProductData> FindProductByConditions(ProductSearch productSearch);
    }
}
