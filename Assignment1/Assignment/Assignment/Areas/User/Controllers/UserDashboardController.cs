using Microsoft.AspNetCore.Mvc;

namespace Assignment.Areas.User.Controllers
{
    public class UserDashboardController : Controller
    {
        [Area("User")]
        [Route("User/[controller]/[action]")]
        public IActionResult UserDashboard()
        {
            return View();
        }
    }
}
