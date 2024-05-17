using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace GISNA.Controllers
{
    public class WithoutmoduleController : Controller
    {
        public IActionResult Index()
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("jisnashaji2008@gmail.com");
            mail.To.Add(new MailAddress("aidabenny18@gmail.com"));
            mail.Subject = "without modules in email ";
            mail.IsBodyHtml = true;
            mail.Body = "<h1>Hello</h1> <br><h2> Hello from ScopeIndia </h2>";
            System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("jisnashaji2008@gmail.com", "zvnz fwxg akbn uxmk");
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail);

            return View();
        }
    }
}
