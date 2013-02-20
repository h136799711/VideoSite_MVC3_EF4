using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoSite.EF.IRepository;
using VideoSite.EF.Infrastructure;
using VideoSite.EF.Model;
namespace VideoSite.site.Controllers
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
            List<User> list = null;
            using (var db = new MSSqlContext())
            {
                db.Configuration.AutoDetectChangesEnabled = true;
                list =  db.Users.ToList();
                
            }
            return View(list);
        }
    }
}
