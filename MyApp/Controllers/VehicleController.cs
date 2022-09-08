using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
