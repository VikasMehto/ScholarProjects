using Assignment.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        [Area("Admin")]
        [Route("Admin/[controller]/[action]")]

        public IActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OnLogin(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("DashBoard", "DashBoard", new { area = "Admin" });

            }
            return RedirectToAction("OnLogin", "Login",new { area = "Admin" });

        }
    }
}
