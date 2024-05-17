using DataBase.DAL;
using DataBase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DataBase.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyProjectDbContext context;

        public HomeController(MyProjectDbContext myDbContext,ILogger<HomeController> logger)
        {
            _logger = logger;
            context = myDbContext;
        }

        public IActionResult Index()
        {
            List<Students> all = context.Students.ToList();
            return View();
        }

        private IActionResult View(object tasks)
        {
            throw new NotImplementedException();
        }

        // GET: Tasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,DueDate")] Task task)
        {
            if (ModelState.IsValid)
            {
                context.Add(task);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        public IActionResult done()
        {
            
            List<Students>all=context.Students.ToList();
            if (all != null)
            {
                ViewBag.a=all;
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            Students stud = new Students();
            stud.Name = "abvc";
            stud.Description = "Shaji";
            stud.DOB = DateTime.Now;
            context.Students.Add(stud);
            context.SaveChanges();
            return View();
        }
        public IActionResult Update()
        {
            Students a = context.Students.Where(s => s.Id == 2).FirstOrDefault();
            if (a != null)
            {
                a.Name = "Salna";
                a.Description = "Sabu";
            }
            context.Students.Update(a);
            context.SaveChanges();
            return View(context);
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}