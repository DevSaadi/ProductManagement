using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProject.Filter
{
    public class LoginActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.Result != null) return;


            string UserName = filterContext.HttpContext.Session.GetString("UserName");
            if (string.IsNullOrEmpty(UserName))
            {
                filterContext.Result = new RedirectResult("~/Home/Login");
            }

        }
    }

}
