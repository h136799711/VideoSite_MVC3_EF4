using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoSite.EF.Infrastructure;
using VideoSite.EF.Model;
namespace VideoSite.Web.Controllers
{
    public class HomeController : Controller
    {        
        public HomeController()
        {
        }
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateInput(false)]
        public ActionResult Add(FormCollection collection)
        {
            this.ValidateRequest = false;
            ViewBag.Message = collection["ckeditor"];

            return View();
        }
    }
}
