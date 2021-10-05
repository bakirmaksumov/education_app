using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace EducationApplication.Common
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        //private readonly IHttpContextAccessor _httpContextAccessor;

        //public CustomAuthorizeAttribute(IHttpContextAccessor httpContextAccessor)
        //{
        //    _httpContextAccessor = httpContextAccessor;
        //}
        //protected override bool AuthorizeCore(Microsoft.AspNetCore.Htt httpContext)
        //{
        //    return Context.User.Identity.IsAuthenticated;
        //}

        //public override void OnAuthorization(AuthorizationFilterContext filterContext)
        //{
        //    bool isAuthenticated = AuthorizeCore(filterContext.HttpContext);
        //    if (isAuthenticated)
        //    {
        //        bool isInRoles = UserIsInRoles(filterContext.HttpContext);
        //        if (!isInRoles)
        //            filterContext.Result = new RedirectResult("~/Error/NotEnoughPermissions");
        //        //else all is OK
        //    }
        //    else
        //        base.OnAuthorization(filterContext);
        //}
    }
}
