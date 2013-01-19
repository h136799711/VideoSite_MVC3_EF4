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
        IUserRepository iuserRepo;
        public HomeController(IUserRepository userRep)
        {
            iuserRepo = userRep;
            using (var db = new MySqlContext())
            {
                db.Configuration.AutoDetectChangesEnabled = true;
                User user = new User() { ID = 123, username="hebidu", password="123456" , extramsg="null" };
                db.Users.Add(user);
                db.SaveChanges();
               
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
            List<User> list = null;
            using (var db = new MySqlContext())
            {
                db.Configuration.AutoDetectChangesEnabled = true;
                list =  db.Users.ToList();
                
            }
            return View(list);
        }
    }
}
