using System.Web.Mvc;
using TheShapeOfDataDemo.Models;

namespace TheShapeOfDataDemo.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(LoginViewModel lvm)
        {
            return View(lvm);
        }
    }
}