using System;
using System.Reflection;
using System.Web.Mvc;

namespace WebApplication2.Filter
{
    public class AjaxOnlyAttribute : ActionMethodSelectorAttribute
    {
        public bool ajax { get; set; }
        public AjaxOnlyAttribute() { ajax = true; }
        public AjaxOnlyAttribute(bool Ajax) { ajax = Ajax; }

        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            return ajax == controllerContext.HttpContext.Request.IsAjaxRequest();
        }
    }
}