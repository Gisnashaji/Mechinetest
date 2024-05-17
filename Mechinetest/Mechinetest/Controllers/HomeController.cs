using Mechinetest.Models;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View(new RegistrationViewModel());
    }

    [HttpPost]
    public ActionResult Index(RegistrationViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Generate Student ID (auto-generated number)
            model.StudentId = Guid.NewGuid().ToString();

            // Save the registration data (not implemented in this example)
            // You can save it to a database or perform any other action here

            return RedirectToAction("Success");
        }
        return View(model);
    }

    public ActionResult Success()
    {
        return View();
    }
}