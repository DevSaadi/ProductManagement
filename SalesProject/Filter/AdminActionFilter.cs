using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProject.Filter
{
    public class AdminActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.Result != null) return;

            var UserType = filterContext.HttpContext.Session.GetInt32("UserType");
            if (UserType != 1)
            {
                filterContext.Result = new RedirectResult("~/Home/Login");
            }

        }
    }

}
