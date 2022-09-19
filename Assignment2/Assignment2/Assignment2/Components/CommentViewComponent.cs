
using Microsoft.AspNetCore.Mvc;
namespace Assignment2.ViewComponents
{
    public class CommentViewComponent:ViewComponent
    {
        static List<string> comments = new List<string>();
        static int count = 0;
        public IViewComponentResult Invoke(string cmnts)
        {
            //TO DO
            
            if (cmnts != null)
            {
                count = count + 1;
                 comments.Add(new string(cmnts + " - (" + count.ToString() + ")"));
            }
            
            return View("~/views/components/_comments.cshtml",comments);

        }

    }
}
