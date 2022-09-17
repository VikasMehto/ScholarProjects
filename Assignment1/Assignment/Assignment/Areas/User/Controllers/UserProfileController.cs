using Microsoft.AspNetCore.Mvc;

namespace Assignment.Areas.User.Controllers
{
    public class UserProfileController : Controller
    {

        [Area("User")]
        [Route("User/[controller]/[action]")]
        public IActionResult Profile()
        {
            return View();
        }
    }
}
