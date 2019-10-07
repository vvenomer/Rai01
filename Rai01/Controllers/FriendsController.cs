using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rai01.Models;

namespace Rai01.Controllers
{
    public class FriendsController : Controller
    {
        // GET: Friends
        public ActionResult Index()
        {
            try
            {
                var login = HttpContext.Session.GetString("login");
                var friends = Startup.friendDatabase.
                    Where(f => f.Friend1 == login).Select(f => f.Friend2).
                    Concat(
                        Startup.friendDatabase.
                        Where(f => f.Friend2 == login).Select(f => f.Friend1)
                        );
                ViewBag.Friends = friends;
            }
            catch
            {
                return BadRequest();
            }

            return View();
        }
        

        [Route("Friends/Add/{login}")]
        [HttpPost]
        public bool Add(string login)
        {

            try
            {
                var myLogin = HttpContext.Session.GetString("login");
                if (CheckIfFriend(myLogin, login))
                    return false;

                Startup.friendDatabase.Add(new Friend { Friend1 = myLogin, Friend2 = login });
                return true;
            }
            catch
            {
                return false;
            }
        }

        // GET: Friends/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Friends/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private bool CheckIfFriend(string login1, string login2)
        {
            if (Startup.friendDatabase.FirstOrDefault(f => f.Friend1 == login1 && f.Friend2 == login2) == null
                &&
                Startup.friendDatabase.FirstOrDefault(f => f.Friend1 == login2 && f.Friend2 == login1) == null)
            {
                return false;
            }
            return true;
        }
    }
}