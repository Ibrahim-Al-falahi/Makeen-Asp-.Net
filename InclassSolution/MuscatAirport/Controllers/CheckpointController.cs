using Microsoft.AspNetCore.Mvc;

namespace MuscatAirport.Controllers
{
    public class CheckpointController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
