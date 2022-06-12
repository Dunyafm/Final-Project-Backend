using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using System.IO;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.Models;

namespace Worldperfumluxury.Controllers
{
    public class SubscribeController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;

        public SubscribeController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }
        public async Task<IActionResult> Subscribe(Subscribe subscripe)
        {
            Subscribe subscribe = new Subscribe
            {
                Email = subscripe.Email
            };




            if (subscribe == null) return RedirectToAction("Index", "Error");

            await _context.Subscribes.AddAsync(subscribe);
            await _context.SaveChangesAsync();
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("Worldperfumluxury", "Dunyafm@code.edu.az"));

            message.To.Add(new MailboxAddress(" ", subscripe.Email));

            message.Subject = "Thank you for Subscribe";

            string emailbody = string.Empty;

            using (StreamReader streamReader = new StreamReader(Path.Combine(_env.WebRootPath, "Templates", "Subscribe.html")))
            {
                emailbody = streamReader.ReadToEnd();
            }





            emailbody = emailbody.Replace("{{email}}", $"{subscribe.Email}");

            message.Body = new TextPart(TextFormat.Html) { Text = emailbody };

            using var smtp = new SmtpClient();

            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("Dunyafm@code.edu.az", "fpqnwcqsuweiidrp");
            smtp.Send(message);


            smtp.Disconnect(true);


            return RedirectToAction("Index", "Home");
        }

    }
}

