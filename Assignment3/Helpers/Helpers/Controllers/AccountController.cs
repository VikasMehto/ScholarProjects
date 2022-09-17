using Microsoft.AspNetCore.Mvc;
using Helpers.Models;

namespace Helpers.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Login(string Username, string Password, string Command)
        //{
        //    if (Command == "Login")
        //    {
        //    }
        //    else
        //    {

        //    }
        //    return View();
        //}
        public IActionResult SignUp()
        {
              return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {
            if( ModelState.IsValid)
            {
                TempData["Message"] = "Sign up is successful !!";

               return RedirectToAction("Message");

            }
            return View();
        }

        public IActionResult Message()
        {
            return View();
        }

      }
}
