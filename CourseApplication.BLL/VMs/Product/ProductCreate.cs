using CourseApplication.BLL.VMs.Brand;
using CourseApplication.BLL.VMs.Category;
using CourseApplication.BLL.VMs.Files;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Product
{
    public class ProductCreate
    {
        public string Name { get; set; }

        public Guid CategoryId { get; set; }
        public Guid BrandId { get; set; }

        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public List<BrandData> BrandsList { get; set; } = new List<BrandData>();
        public List<CategoryData> CategoryList { get; set; } = new List<CategoryData>();

        public List<IFormFile> Files { get; set; }
    }
}
