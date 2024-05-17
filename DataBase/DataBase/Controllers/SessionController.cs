using Microsoft.AspNetCore.Mvc;

namespace DataBase.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("FullName", "Scope India");
            return View();
        }
        public IActionResult Members()
        {
            if(HttpContext.Session.GetString("FullName")!=null)
            {
                Console.WriteLine("Session available");
                ViewBag.Name = HttpContext.Session.GetString("FullName");
            }
            else
            {
                ViewBag.Name = "No Sessions Found";
            }
            return View();
        }
    }
}
