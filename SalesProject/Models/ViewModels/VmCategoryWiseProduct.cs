using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProject.Models.ViewModels
{
    public class VmCategoryWiseProduct
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<VmCategory> CategoryList { get; set; }
        public List<VmProduct> ProductList { get; set; }
    }
}
