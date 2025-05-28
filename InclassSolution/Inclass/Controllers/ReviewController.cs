using Microsoft.AspNetCore.Mvc;

namespace Inclass.Controllers
{
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
