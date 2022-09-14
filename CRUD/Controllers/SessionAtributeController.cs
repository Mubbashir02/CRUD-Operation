using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.ModelBinding;

namespace CRUD.Controllers
{
    public class SessionAtributeController : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(HttpContext.Current.Session["id"] == null)
            {
                filterContext.Result = new RedirectResult(@"~\\Login\\Index");
            }

            base.OnActionExecuting(filterContext);
        }

	}
}