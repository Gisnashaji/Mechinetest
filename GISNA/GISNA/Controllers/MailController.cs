using Microsoft.AspNetCore.Mvc;
using MailKit.Security;
using MimeKit.Text;
using System.Diagnostics;
using MailKit.Net.Smtp;
using MimeKit;

namespace GISNA.Controllers
{
    public class MailController : Controller
    {
        public IActionResult Index()
        {
            var email=new MimeMessage();
            email.From.Add(MailboxAddress.Parse("jisnashaji2008@gmail.com"));
            email.To.Add(MailboxAddress.Parse("aidabenny18@gmail.com"));
            email.Subject = "Test Email From Scope India";
            email.Body=new TextPart(TextFormat.Html) { Text="<h1>Scope India Example HTML Message Body</h1>"};

            using var smtp = new SmtpClient() ;
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("jisnashaji2008@gmail.com", "zvnz fwxg akbn uxmk");
            smtp.Send(email);
            smtp.Disconnect(true);
            ViewBag.Message = "A mail has been sent successfully";
            return View();
        }
    }
}
