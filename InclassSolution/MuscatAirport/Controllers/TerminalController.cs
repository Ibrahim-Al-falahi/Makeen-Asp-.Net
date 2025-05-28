using Microsoft.AspNetCore.Mvc;

namespace MuscatAirport.Controllers
{
    public class TerminalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
