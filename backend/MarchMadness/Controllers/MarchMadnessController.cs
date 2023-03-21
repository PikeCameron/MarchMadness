using Microsoft.AspNetCore.Mvc;

namespace MarchMadness.Controllers
{
    public class MarchMadnessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
