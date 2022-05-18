using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("isAdmin") != null)
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register() 
        {
            if (HttpContext.Session.GetInt32("isAdmin") != null && HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                return View();
            }
            return RedirectToAction("Index", "Account");
        }
    }
}
