using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Rai01.Controllers
{
    public class SignInController : Controller
    {
        [Route("Login/{login}")]
        public IActionResult Login(string login)
        {
            if(Startup.userDatabase.ContainsKey(login) || login == "admin")
            {
                HttpContext.Session.SetString("login", login);
                return RedirectToAction("Index", "Friends");
            }
            return BadRequest("Not registered");
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("login");
            return RedirectToAction("Index", "Friends");
        }
    }
}