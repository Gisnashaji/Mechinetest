using Microsoft.AspNetCore.Mvc;

namespace GISNA.Controllers
{
    public class GisnaController : Controller
    {
        public IActionResult Index()
        {

            return Redirect("/Home/Privacy");
        }
        public IActionResult Privacy()
        {
            string name = "hai";
            return RedirectToAction("Privacy", "Model", new { scope = name });
        }
        public IActionResult About_us()
        {
            return View();
        }
        public IActionResult Details()
        {
            TempData["ActiveMethod"] = "data passed";
            return View();
        }
        public IActionResult People()
        {
            string name = "hello world";
            return RedirectToAction("People", "Model", new { standing = name });
        }
    }
}
