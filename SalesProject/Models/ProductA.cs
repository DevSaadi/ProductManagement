using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProject.Models
{
    public class ProductA
    {
        [Key]
        public int ProductID { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        public string Price { get; set; }

        [Display(Name = "Order Date")]
        public string OrderDate { get; set; }

        public string ImagePath { get; set; }
        [NotMapped]
        public IFormFile ImageUpload { get; set; }

        public ProductA()
        {
            ImagePath = "~/Images/default.png";
        }
    }
}
