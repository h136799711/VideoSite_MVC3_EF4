using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoSite.Services.IServices;
using VideoSite.EF.IRepository;

namespace VideoSite.Web.Controllers
{
    public class UserController : Controller
    {
        protected IUserService m_UserService;

        public UserController(IUserService UserService)
        {
            m_UserService = UserService;
        }
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View(m_UserService.List());
        }

        //
        // GET: /User/Details/5

        public ActionResult Details(int id)
        {
            return View(m_UserService.GetUserById(id));
        }

        //
        // GET: /User/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /User/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
                return RedirectToAction("Index");
        }
        
        //
        // GET: /User/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(m_UserService.GetUserById(id));
        }

        //
        // POST: /User/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /User/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /User/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
