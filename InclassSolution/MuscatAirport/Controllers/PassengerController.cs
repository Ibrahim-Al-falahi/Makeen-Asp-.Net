using Microsoft.AspNetCore.Mvc;

namespace MuscatAirport.Controllers
{
    public class PassengerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
