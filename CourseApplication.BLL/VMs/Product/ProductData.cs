using CourseApplication.BLL.VMs.Brand;
using CourseApplication.BLL.VMs.Category;
using CourseApplication.BLL.VMs.Files;
using CourseApplication.BLL.VMs.Review;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Product
{
    public class ProductData
    {
        public Guid ProductId { get; set; }

        public string Name { get; set; }

        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }

        public Guid BrandId { get; set; }
        public string BrandName { get; set; }

        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        public double Score { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Guid ActionId { get; set; }

        public int OrderNumber { get; set; }
        public int WishlistNumber { get; set; }

        public bool InWishlist { get; set; } = false;
        public Guid? WishlistPositionId { get; set; } = null;

        public bool InCart { get; set; } = false;
        public Guid? CartPositionId { get; set; } = null;

        public virtual List<ReviewData> Reviews { get; set; } = new List<ReviewData>();

        public List<BrandData> BrandsList { get; set; } = new List<BrandData>();
        public List<CategoryData> CategoryList { get; set; } = new List<CategoryData>();

        public List<FileCreate> Files { get; set; } = new List<FileCreate>();
    }
}
