using Microsoft.AspNetCore.Mvc;

namespace BED21Lab.Controllers
{
    public class PhotosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cosmos()
        {
            return View();
        }
        public IActionResult Dahlia
            ()
        {
            return View();
        }
        public IActionResult Lotus()
        {
            return View();
        }

        public ActionResult photoView(string id)
        {
            ViewBag.photo = id;
            return View();
        }
    }
}
