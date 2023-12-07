namespace BulkyBook.Utility
{
    public class IEmailSenderNew
    {
        public interface IEmailSender
        {
            Task SendEmailAsync(string email, string subject, string htmlMessage);
        }
    }
}
