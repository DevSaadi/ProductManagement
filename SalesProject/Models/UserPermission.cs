using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProject.Models
{
    public partial class UserPermission
    {
        [Key]
        public int PermissionId { get; set; }
        public int MenuIid { get; set; }
        public bool? IsRead { get; set; }
        public bool? IsCreate { get; set; }
        public bool? IsUpdate { get; set; }
        public bool? IsDelete { get; set; }
        public int? UserId { get; set; }
    }
}
