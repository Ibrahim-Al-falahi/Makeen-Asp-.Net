using Microsoft.AspNetCore.Mvc;

namespace Inclass.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
