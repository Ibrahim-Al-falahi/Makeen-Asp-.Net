using Microsoft.AspNetCore.Mvc;

namespace Inclass.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
