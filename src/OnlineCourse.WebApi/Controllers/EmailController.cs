using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using OnlineCourse.Service.Dtos.Common;
using System.Reflection;

namespace OnlineCourse.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        public async Task<bool> SendEmail(string body)
        {
            try
            {
                var mail = new MimeMessage();
                mail.From.Add(MailboxAddress.Parse("SamandarbekYR@gmail.com"));
                mail.To.Add(MailboxAddress.Parse("uzgrandmaster@gmail.com"));
                mail.Subject = "Test";
                mail.Body = new TextPart(TextFormat.Html)
                {
                    Text = body,
                };

                using var smtp = new MailKit.Net.Smtp.SmtpClient();
                await smtp.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync("SamandarbekYR@gmail.com", "cyiqxqrncxulnvcf");
                await smtp.SendAsync(mail);
                await smtp.DisconnectAsync(true);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
