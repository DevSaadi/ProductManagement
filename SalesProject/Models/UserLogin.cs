using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProject.Models
{
    public partial class UserLogin
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public int? UserType { get; set; }
    }
}
