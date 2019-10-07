using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Rai01.Controllers
{
    public class SignInController : Controller
    {
        [Route("Login/{login}")]
        public IActionResult Login(string login)
        {
            HttpContext.Session.SetString("login", login);
            return RedirectToAction("Index", "Friends");
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("login");
            return RedirectToAction("Index", "Friends");
        }
    }
}