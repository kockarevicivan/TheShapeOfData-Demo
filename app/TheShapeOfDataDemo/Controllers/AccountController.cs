using System.Web.Mvc;
using System.Web.Security;
using TheShapeOfDataDemo.Models;

namespace TheShapeOfDataDemo.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel lvm)
        {
            FormsAuthentication.SetAuthCookie(lvm.Username, false);

            return RedirectToAction("Index", "Home", lvm);
        }

        [HttpGet]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }
    }
}