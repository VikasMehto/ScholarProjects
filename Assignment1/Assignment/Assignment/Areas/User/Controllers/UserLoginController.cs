using Microsoft.AspNetCore.Mvc;
using Assignment.Areas.User.Models;

namespace Assignment.Areas.User.Controllers
{
    public class UserLoginController : Controller
    {
        [Area("User")]
        [Route("User/[controller]/[action]")]

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult OnUserLogin(UserLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("UserDashBoard", "UserDashBoard", new { area = "User" });

            }
            return RedirectToAction("OnUserLogin", "UserLogin", new { area = "User" });
            
        }
    }
}
