using Do_An_KDCLPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Do_An_KDCLPM.Areas.admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var acc = Session["account_admin"] as accounts;
            if (acc == null || !acc.role.name.Equals("admin"))
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { controller = "Login", action = "Index", Area = "Admin" }
                        ));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}