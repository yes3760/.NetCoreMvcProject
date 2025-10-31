using Microsoft.AspNetCore.Mvc;
using CvSiteNet9_Modern.Models;
using System.Net.Mail;
using System.Net;

namespace CvSiteNet9_Modern.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View(new ContactMessage());

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Index(ContactMessage model, [FromServices] IConfiguration config, [FromServices] ILogger<ContactController> logger)
        {
            if (!ModelState.IsValid) return View(model);

            try
            {
                var host = config["Smtp:Host"];
                var port = int.TryParse(config["Smtp:Port"], out var p) ? p : 587;
                var user = config["Smtp:User"];
                var pass = config["Smtp:Pass"];
                var from = config["Smtp:From"] ?? user;
                var to = config["Smtp:To"] ?? user;

                if (!string.IsNullOrWhiteSpace(host) && !string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pass) && !string.IsNullOrWhiteSpace(to))
                {
                    using var client = new SmtpClient(host, port) { Credentials = new NetworkCredential(user, pass), EnableSsl = true };
                    using var msg = new MailMessage(from!, to!) { Subject = $"Yeni ileti: {model.Name}", Body = $"İsim: {model.Name}\nE-posta: {model.Email}\n\nMesaj:\n{model.Message}" };
                    client.Send(msg);
                }
                else
                {
                    logger.LogInformation("SMTP yapılandırılmadı; ileti loglandı. {Name} - {Email}", model.Name, model.Email);
                }
            }
            catch (Exception ex) { logger.LogError(ex, "İleti gönderilirken hata oluştu."); }

            return RedirectToAction("Thanks");
        }

        public IActionResult Thanks() => View();
    }
}
