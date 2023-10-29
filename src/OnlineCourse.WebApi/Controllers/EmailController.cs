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
            // SMTP server bilan ulanish
            //using var smtp = new SmtpClient();
            //smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);

            //// Autentifikatsiya
            //smtp.Authenticate("SamandarbekYR@gmail.com", "cyiq xqrn cxul nvcf");

            //// Xabar tayyorlash
            //var email = new MimeMessage();
            //email.From.Add(MailboxAddress.Parse("SamandarbekYR@gmail.com"));
            //email.To.Add(MailboxAddress.Parse("uzgrandmaster@gmail.com"));
            //email.Subject = "Test Email Subject";
            //email.Body = new TextPart(TextFormat.Html) { Text = body };

            //// Xabarni yuborish
            //smtp.Send(email);

            //// Server bilan ulanishni yakunlash
            //smtp.Disconnect(true);

            //return Ok();
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
