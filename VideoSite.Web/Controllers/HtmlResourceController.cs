using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideoSite.Web.Controllers
{
    /// <summary>
    /// Html Resourece Getter Controller
    /// </summary>
    public class HtmlResourceController : Controller
    {
        //
        // GET: /HtmlResource/

        public ActionResult Get(string htmlName)
        {
            return View(htmlName);
        }

    }
}
