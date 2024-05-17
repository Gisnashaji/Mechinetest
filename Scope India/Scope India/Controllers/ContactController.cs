using Microsoft.AspNetCore.Mvc;

namespace Scope_India.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
