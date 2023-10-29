using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using OnlineCourse.Service.Dtos.Common;
using OnlineCourse.Service.Interfaces.Common;

namespace OnlineCourse.Service.Services.Common
{
    public class EmailSender : IEmailService
    {
        private readonly string SENDER = string.Empty;
        private readonly string HOST = string.Empty;
        private readonly string PORT = string.Empty;
        private readonly string PASSWORD = string.Empty;
        public EmailSender(IConfiguration configuration)
        {
            SENDER = configuration["sender"]!;
            HOST = configuration["host"]!;
            PORT = configuration["port"]!;
            PASSWORD = configuration["password"]!;
        }
        public async Task<bool> SendAsync(EmailMessage emailMessage)
        {
            try
            {
                var mail = new MimeMessage();
                mail.From.Add(MailboxAddress.Parse(SENDER));
                mail.To.Add(MailboxAddress.Parse(emailMessage.Recipent));
                mail.Subject = emailMessage.Title;
                mail.Body = new TextPart(TextFormat.Html)
                {
                    Text = emailMessage.Content,
                };

                using var smtp = new MailKit.Net.Smtp.SmtpClient();
                await smtp.ConnectAsync(HOST, int.Parse(PORT), MailKit.Security.SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(SENDER, PASSWORD);
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
