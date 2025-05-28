using Microsoft.AspNetCore.Mvc;

namespace MuscatAirport.Controllers
{
    public class OfficerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
