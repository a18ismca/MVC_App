using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
