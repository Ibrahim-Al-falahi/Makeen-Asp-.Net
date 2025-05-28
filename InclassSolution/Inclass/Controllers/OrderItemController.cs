using Microsoft.AspNetCore.Mvc;

namespace Inclass.Controllers
{
    public class OrderItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
