
namespace VideoSite.Web.Controllers
{
    using System.Web.Mvc;
    using VideoSite.Services.IServices;
    using System.Collections;
    using System.Linq;
    /// <summary>
    /// User Controller
    /// </summary>
    public class UserController : Controller
    {
        /// <summary>
        /// The m_ user service
        /// </summary>
        protected IUserService m_UserService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// </summary>
        /// <param name="UserService">The user service.</param>
        public UserController(IUserService UserService)
        {
            m_UserService = UserService;
        }

        /// <summary>
        /// Indexes this instance.
        /// GET: /User/Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {

            if (Request.IsAjaxRequest())
            {
                IEnumerable list = from user in m_UserService.List() select new { user.UserId, user.Username,user.Password,user.UserInfoId,user.Extra };
                return Json(list);
            }
            else
            {
                return View(m_UserService.List());
            }
        }

        /// <summary>
        /// Detailses the specified id.
        ///  GET: /User/Details/5
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            if (Request.IsAjaxRequest())
            {
                return View("JSDetails.html", m_UserService.GetUserById(id));
            }
            else
            {
                return View(m_UserService.GetUserById(id));
            }
        }

        /// <summary>
        /// Creates this instance.
        /// GET: /User/Create
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            if (Request.IsAjaxRequest())
            {
                return View("JSCreate.html");
            }
            else
            {
                return View();
            }
        }

        /// <summary>
        /// Creates the specified collection.
        /// POST: /User/Create
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
                return RedirectToAction("Index");
        }
        
        /// <summary>
        /// Edits the specified id.
        /// GET: /User/Edit/5
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            if (Request.IsAjaxRequest())
            {
                return View("JSCreate.html", m_UserService.GetUserById(id));
            }
            else
            {
                return View(m_UserService.GetUserById(id));
            }
        }
        
        /// <summary>
        /// Edits the specified id.
        /// POST: /User/Edit/5
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="collection">The collection.</param>
        /// <returns></returns>
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
        
        /// <summary>
        /// Deletes the specified id.
        /// GET: /User/Delete/5
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {
            return View();
        }

        /// <summary>
        /// Deletes the specified id.
        /// POST: /User/Delete/5
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="collection">The collection.</param>
        /// <returns></returns>
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
