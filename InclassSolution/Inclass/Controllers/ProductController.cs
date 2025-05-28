using Microsoft.AspNetCore.Mvc;

namespace Inclass.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
