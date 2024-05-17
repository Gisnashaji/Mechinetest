using Microsoft.AspNetCore.Mvc;

namespace DataBase.Controllers
{
    public class CookiesController : Controller
    {
        public IActionResult Index()
        {
            CookieOptions options = new CookieOptions();
            options.Expires=DateTimeOffset.Now.AddDays(1);
            HttpContext.Response.Cookies.Append("FullName", "Scope India", options);
            return View();
        }
        public IActionResult Members()
        {
            if (HttpContext.Request.Cookies["FullName"] != null)
            {
                ViewData["Name"] = HttpContext.Request.Cookies["FullName"];
            }
            else
            {
                ViewData["Name"] = "No Cookie Found";
            }
            return View();
        }
    }
}
