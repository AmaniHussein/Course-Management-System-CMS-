namespace Final8Net.Interfaces
{
    public interface IEmailSign
    {
        Task SendEmailLoginAsync(string email, string subject, string message, string verificationCode);
    }
}