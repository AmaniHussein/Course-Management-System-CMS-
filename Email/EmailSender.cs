using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using Final8Net.Interfaces;

namespace Final8Net.Email
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message, string verificationCode)
        {
            var mail = "celevercampus@outlook.com";
            //var pass = "";
            //var host="";
            //if (email != null && email.Contains("@gmail.com") )
            //{
            //var host = "smtp.gmail.com";
            //var pass = "rcheohjqtjrgzyhl";
            //}else if(email != null && email.Contains("@gmail.com"))
            //{
            var host = "smtp.office365.com";
            var pass = "altjonopkdaypchp";
            //}
            var client = new SmtpClient(host, 587)
            {
                UseDefaultCredentials = false,
                EnableSsl = true,
                Credentials = new NetworkCredential(mail, pass)
            };

            subject = "CleverCampus Verification";
            message = "Thanks for starting the new CleverCampus account creation process." +
                " We want to make sure it's really you." +
                " Please enter the following verification code when prompted." +
                " If you don’t want to create an account," +
                " you can ignore this message.\r\n\r\n";
            message += $"\r\n\r\nYour verification code is: {verificationCode}";
            return client.SendMailAsync(
                new MailMessage(from: mail,
                                to: email,
                                subject,
                                message));
        }
    }
}