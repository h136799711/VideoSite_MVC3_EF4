using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideoSite.Web.Controllers
{
    public class ErrorController : Controller
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {

            ViewData["msg"] = "发生了一个异常";
            return View();
        }

        /// <summary>
        /// Nots the found.
        /// </summary>
        /// <returns></returns>
        public ActionResult NotFound()
        {
            if (Request.IsAjaxRequest())
            {
                return Json(new { Code = 404 }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return View();
            } 
        }

        /// <summary>
        /// Unknowns this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Unknown()
        {
            if (Request.IsAjaxRequest())
            {
                return Json(new { Code = -1024 }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return View();
            } 
        }
    }
}
