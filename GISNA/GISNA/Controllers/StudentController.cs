using GISNA.Models;
using Microsoft.AspNetCore.Mvc;

namespace GISNA.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Student student)
        {
            var return_page = "Index";
            if(ModelState.IsValid)
            {
                ViewBag.finalcontent = student.Name;
                ViewBag.Success = "successfully Registered";
                return_page = "Success";
            }
            return View(return_page);
        }
    }
}
