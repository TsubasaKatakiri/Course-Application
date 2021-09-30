using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApplication.BLL.VMs.Product
{
    public class ProductSearch
    {
        public string ProductName { get; set; } = null;
        public string CategoryName { get; set; } = null;
        public string BrandName { get; set; } = null;

        public double ScoreMin { get; set; } = 0.0;
        public double ScoreMax { get; set; } = 0.0;

        public decimal PriceMin { get; set; } = 0.0M;
        public decimal PriceMax { get; set; } = 0.0M;

        public string SortBy { get; set; }
        public bool IsBackwardsSorting { get; set; }
    }
}
