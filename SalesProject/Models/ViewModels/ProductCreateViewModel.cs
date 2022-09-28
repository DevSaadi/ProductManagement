using Microsoft.AspNetCore.Http;
using SalesProject.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProject.Models.ViewModels
{
    public class ProductCreateViewModel
    {
        [Key]
        public int ProductId { get; set; }
        [DisplayName("Product Name")]
        [Required(ErrorMessage = "This Field is required.")]
        [ExcludeCharacter("@!?")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "This Field is required.")]
        public string Price { get; set; }
        [DisplayName("Order Date")]
        [Required(ErrorMessage = "This Field is required.")]
        [custom]
        public System.DateTime OrderDate { get; set; }
        [DisplayName("Image Name")]
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
