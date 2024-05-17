using Microsoft.Data.SqlClient;
using Scope_India.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Scope_India.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Placement()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult PrivacyAndTerms()
        {
            return View();
        }
        public IActionResult Careers()
        {
            return View();
        }
       

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Register(RegisterModel reg)
        //{
            
        //    if (ModelState.IsValid)
        //    {
        //        ViewBag.finalcontent = reg.FirstName;
        //        ViewBag.Success = "Successfully Registered";
        //        return View("Success");           }
        //    return View("Register",reg);
        //}
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
   