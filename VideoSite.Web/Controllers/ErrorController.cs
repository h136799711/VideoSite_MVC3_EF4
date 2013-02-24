using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideoSite.Web.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/

        public ActionResult Index()
        {

            ViewData["msg"] = "发生了一个异常";
            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }

        public ActionResult Unknown()
        {
            return View();
        }
    }
}
