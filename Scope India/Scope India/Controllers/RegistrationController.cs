using Microsoft.AspNetCore.Mvc;
using Scope_India.Models;

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Scope_India.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly Registration obj = new Registration();
        private readonly IConfiguration configuration;
        private string connection;

        public RegistrationController(IConfiguration _configuration)
        {
            configuration = _configuration;
            connection = configuration.GetConnectionString("DefaultConnection");
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(RegisterModel reg, List<string> selectedHobbies, IFormFile upload)
        {
            try
            {
                // Convert the selectedLanguages list to a comma-separated string
                reg.Hobbies = selectedHobbies;

                // Convert IFormFile to byte[]
                using (var memoryStream = new MemoryStream())
                {
                    upload.CopyTo(memoryStream);
                    reg.Upload = memoryStream.ToArray();
                }

                obj.CreateReg(reg, connection);
                return View("Save");
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }

    }
}

        
    
