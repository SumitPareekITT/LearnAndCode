using DIP.HighLevel;
using DIP.Services;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailService = new EmailNotification();
            var manager = new NotificationManager(emailService);

            manager.Notify("Payment Successful");

            var smsService = new SmsNotification();
            manager = new NotificationManager(smsService);

            manager.Notify("OTP Sent");

            Console.ReadLine();
        }
    }
}
