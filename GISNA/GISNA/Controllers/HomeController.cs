using GISNA.DAL;
using GISNA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GISNA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyProjectDbContext Context;

        public HomeController(MyProjectDbContext MyDbContent,ILogger<HomeController> logger)
        {
            _logger = logger;   
            Context = MyDbContent;

        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            //Students stud=new Students();
            //stud.Name = "Klm";
            //stud.LastName = "Nop";
            //stud.Age = 30;
            //Context.Students.Add(stud);
            //Context.SaveChanges();

            Students a=Context.Students.Where(s=>s.Id==1).FirstOrDefault();
            if (a!=null)
            {
                a.Age = 15;
            }
            Context.Students.Update(a);
            Context.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}