using GISNA.Models;
using Microsoft.AspNetCore.Mvc;

namespace GISNA.Controllers
{
    public class ModelController : Controller
    {
        public IActionResult Index()
        {
            MyModel m = new MyModel()
            {
                Id = 1,
                Name = "anna",
            };
            return View(m);
        }
        public IActionResult Details()
        {
            ViewBag.G = TempData["ActiveMethod"] as string;
            return View();
        }
        public IActionResult Privacy(string scope)
        {
            ViewBag.A = scope;
            return View();
        }
        public IActionResult People(string standing)
        {
            ViewBag.B = standing;
            return View();
        }
    }
}
