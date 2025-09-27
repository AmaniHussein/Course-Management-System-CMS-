using MimeKit;
using MailKit.Net.Smtp;
using Final8Net.Interfaces;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Final8Net.Email
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;

        // Inject IConfiguration into the constructor
        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendEmailAsync(string email, string subject, string message, string verificationCode)
        {
            // Read settings from configuration instead of hard-coding them
            var mail = _configuration["EmailSettings:Email"];
            var pass = _configuration["EmailSettings:Password"];
            var host = _configuration["EmailSettings:Host"];

            // 1. Create the email message using MimeKit
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("CleverCampus", mail));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = "CleverCampus Verification";

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = $@"
                <p>Thanks for starting the new CleverCampus account creation process. We want to make sure it's really you.</p>
                <p>Please enter the following verification code when prompted. If you don’t want to create an account, you can ignore this message.</p>
                <br>
                <p>Your verification code is: <strong>{verificationCode}</strong></p>";

            emailMessage.Body = bodyBuilder.ToMessageBody();

            // 2. Use MailKit's SmtpClient to connect and send
            using (var client = new SmtpClient())
            {
                // Connect to the server using STARTTLS
                await client.ConnectAsync(host, 587, MailKit.Security.SecureSocketOptions.StartTls);

                // Authenticate with your username and app password
                await client.AuthenticateAsync(mail, pass);

                // Send the email
                await client.SendAsync(emailMessage);

                // Disconnect
                await client.DisconnectAsync(true);
            }
        }
    }
}