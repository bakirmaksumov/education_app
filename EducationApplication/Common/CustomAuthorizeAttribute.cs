using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace EducationApplication.Common
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CustomAuthorizeAttribute(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        //protected override bool AuthorizeCore(HttpContext httpContext)
        //{
        //    var isAuthorized = _httpContextAccessor.HttpContext.User.Identity.IsAuthenticated;

        //    if (isAuthorized == false)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        var users = Users.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        //        if (users != null && users.Contains(httpContext.User.Identity.Name))
        //        {
        //            return true;
        //        }

        //        var roles = Roles.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        //        IRoleService roleService = DependencyResolver.Current.GetService<IRoleService>();

        //        return roleService.IsUserInRoles(httpContext.User.Identity.Name, roles);

              
        //    }
        //}
    }
}
