using Microsoft.AspNetCore.Mvc;
using Assignment2.Models;

namespace Assignment2.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OnAdd(ArticleViewModel model)
        {
            if(ModelState.IsValid)
            {
                if(model.comments != null)
                {
                    ViewBag.AddedComments = model.comments;
                }
                return View("Index");

            }
            return View("Index");
        }
    }
}
