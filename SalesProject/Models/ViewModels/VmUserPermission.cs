using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProject.Models.ViewModels
{
    public class VmUserPermission
    {
        public UserLogin UserLogin { get; set; }
        public List<UserPermission> ListUserPermission { get; set; }
    }

}
