using Microsoft.AspNetCore.Mvc;

namespace BED21Lab.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
