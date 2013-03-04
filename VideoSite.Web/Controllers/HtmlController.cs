using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideoSite.Web.Controllers
{
    /// <summary>
    /// Html Pages Getter Controller
    /// </summary>
    public class HtmlController : Controller
    {



        /// <summary>
        ///  用户管理页面
        /// </summary>
        /// <param name="htmlName">Name of the HTML File.</param>
        /// <returns></returns>
        public ActionResult HUser(string htmlName)
        {
            return View(htmlName);
        }
    }
}
