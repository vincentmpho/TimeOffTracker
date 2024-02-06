using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace TimeOffTracker.Web.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly string _smtpServer;
        private readonly int _smptpPort;
        private readonly string _fromEmailAddress;

        public EmailSender(string smtpServer, int smptpPort, string fromEmailAddress)
        {
            _smtpServer = smtpServer;
            _smptpPort = smptpPort;
            _fromEmailAddress = fromEmailAddress;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage
            {
                From = new MailAddress(_fromEmailAddress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            message.To.Add(new MailAddress(email));


            using var client = new SmtpClient(_smtpServer, _smptpPort);

            client.Send(message);

            return Task.CompletedTask;
        }
    }
}
