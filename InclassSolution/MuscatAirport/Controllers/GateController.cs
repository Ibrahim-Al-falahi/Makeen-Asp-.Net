using Microsoft.AspNetCore.Mvc;

namespace MuscatAirport.Controllers
{
    public class GateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
