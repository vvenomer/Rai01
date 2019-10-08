using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rai01.Models;

namespace Rai01.Controllers
{
    public class UserController : Controller
    {
        [Route("User/List")]
        public ActionResult Index()
        {
            if(!IsAdmin())
            {
                return BadRequest("Only Admin has access to this page!");
            }
            return View(Startup.userDatabase.Select(u => u.Value));
        }

        public ActionResult Init()
        {
            if (!IsAdmin())
            {
                return BadRequest("Only Admin has access to this page!");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Init(string users, string friends)
        {
            if (!IsAdmin())
            {
                return BadRequest("Only Admin has access to this page!");
            }
            try
            {
                List<string> usersList = JsonConvert.DeserializeObject<List<string>>(users);
                List<Friend> friendsList = JsonConvert.DeserializeObject<List<Friend>>(friends);

                Startup.userDatabase = Startup.userDatabase.Concat(usersList.ToDictionary(
                    u => u,
                    u => new User
                    {
                        login = u,
                        createdTime = DateTime.Now
                    })).ToDictionary(u => u.Key, u => u.Value);
                Startup.friendDatabase = Startup.friendDatabase.Concat(friendsList).ToList();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

        }

        [Route("User/Add")]
        public ActionResult Create()
        {
            if (!IsAdmin())
            {
                return BadRequest("Only Admin has access to this page!");
            }
            return View();
        }
        
        [HttpPost("User/Add")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string login)
        {
            if (!IsAdmin())
            {
                return BadRequest("Only Admin has access to this page!");
            }
            try
            {
                var user = new User
                {
                    login = login,
                    createdTime = DateTime.Now
                };
                Startup.userDatabase.Add(login, user);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [Route("User/Delete/{login}")]
        public ActionResult Delete(string login)
        {
            if (!IsAdmin())
            {
                return BadRequest("Only Admin has access to this page!");
            }
            return View(Startup.userDatabase[login]);
        }

        // POST: User/Delete/5
        [HttpPost("User/Delete/{login}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string login)
        {
            if (!IsAdmin())
            {
                return BadRequest("Only Admin has access to this page!");
            }
            try
            {
                Startup.userDatabase.Remove(login);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private bool IsAdmin()
        {
            if (HttpContext.Session.TryGetValue("login", out byte[] value))
                return HttpContext.Session.GetString("login") == "admin";
            return false;
        }
    }
}