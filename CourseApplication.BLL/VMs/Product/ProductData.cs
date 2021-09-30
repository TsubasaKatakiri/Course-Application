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

        public virtual List<ReviewData> Reviews { get; set; } = new List<ReviewData>();
    }
}
