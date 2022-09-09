using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagementApp.Web.Services
{
    public class EmailSender : IEmailSender
    {
        private string _smtpSever;
        private int _smtpPort;
        private string _fromEmailAddress;

        public EmailSender(string smtpSever, int smtpPort, string fromEmailAddress)
        {
            this._smtpSever = smtpSever;
            this._smtpPort = smtpPort;
            this._fromEmailAddress = fromEmailAddress;
        }

        //Sends Email
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

            using (var client = new SmtpClient(_smtpSever, _smtpPort))
            client.Send(message);

            return Task.CompletedTask;
           
        }
    }
}
