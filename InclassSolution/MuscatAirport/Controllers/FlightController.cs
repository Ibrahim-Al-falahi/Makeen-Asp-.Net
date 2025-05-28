using Microsoft.AspNetCore.Mvc;

namespace MuscatAirport.Controllers
{
    public class FlightController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
