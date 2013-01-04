using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoSite.EF.Repository;
using VideoSite.EF.Infrastructure;
using VideoSite.EF.Model;
namespace VideoSite.site.Controllers
{
    public class HomeController : Controller
    {
        IUserRepository iuserRepo;
        public HomeController(IUserRepository userRep)
        {
            iuserRepo = userRep;
            using (var db = new MainContext())
            {
                db.Configuration.AutoDetectChangesEnabled = true;
                User user = new User() { ID = 123, username="hebidu", password="123456" , extramsg="null" };
                db.Users.Add(user);

               
              //  db.Users.Attach(user);
            }
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
    }
}
