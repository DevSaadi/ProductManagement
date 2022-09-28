using SalesProject.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProject.Models
{
    public class tblProduct
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "This Field is required.")]
        [ExcludeCharacter("@!?")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "This Field is required.")]
        public string Price { get; set; }
        [Required(ErrorMessage = "This Field is required.")]
        [custom]
        public DateTime OrderDate { get; set; }

        public string ImageName { get; set; }

        public string ImageUrl { get; set; }
    }
}
