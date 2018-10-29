﻿using System.Web.Mvc;
using System.Web.Security;

namespace METU.VRS
{
    public class FormsAuthAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            FormsAuthentication.RedirectToLoginPage();
            filterContext.Result = new EmptyResult();
        }
    }
}
