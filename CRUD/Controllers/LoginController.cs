using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login log)
        {
            if (log.Check())
            {
                HttpContext.Session["id"] = log.Userid;
                Login.C = true;
            }
            return RedirectToAction("MyView", "Login");
        }

        public ActionResult MyView()
        {
            return View();
        }

}
}