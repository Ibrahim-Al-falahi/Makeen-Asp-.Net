using Microsoft.AspNetCore.Mvc;

namespace Inclass.Controllers
{
    public class ShippingAddressController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
