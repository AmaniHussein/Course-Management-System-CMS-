using Final8Net.Interfaces;
using System.Net.Mail;
using System.Net;

namespace Final8Net.Email
{
    public class EmailSigner : IEmailSign
    {
        public Task SendEmailLoginlAsync(string email, string subject, string message, string verificationCode)
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

            subject = "CleverCampus Login Verification";
            message = "Thank you for attempting to log in to your CleverCampus account." +
                " To ensure the security of your account, please enter the following verification code when prompted." +
                " If you did not request this login attempt, please ignore this message or contact our support team immediately.\r\n\r\n";
            message += $"\r\n\r\nYour verification code is: {verificationCode}";
            return client.SendMailAsync(
                new MailMessage(from: mail,
                                to: email,
                                subject,
                                message));
        }
    }
}