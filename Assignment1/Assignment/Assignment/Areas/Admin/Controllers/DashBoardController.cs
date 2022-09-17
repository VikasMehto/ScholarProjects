using Microsoft.AspNetCore.Mvc;

namespace Assignment.Areas.Admin.Controllers
{
    public class DashBoardController : Controller
    {
        [Area("Admin")]
        [Route("Admin/[controller]/[action]")]
        public IActionResult DashBoard()
        {
            return View();
        }
    }
}
