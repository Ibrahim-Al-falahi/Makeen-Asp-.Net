using Microsoft.AspNetCore.Mvc;

namespace MuscatAirport.Controllers
{
    public class BaggageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
