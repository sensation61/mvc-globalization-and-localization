using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Filter
{
    public class AuthorizeFilter : AuthorizeAttribute
    {

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            var IsAuthenticated = filterContext.HttpContext.User.Identity.IsAuthenticated;

            var a = filterContext.RequestContext.HttpContext.Request.Cookies;

        }
    }
}