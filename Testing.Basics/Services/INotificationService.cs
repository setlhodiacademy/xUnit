namespace Testing.Basics.Services
{
    public interface INotificationService
    {
        void NotifyAllChannels(string message);
        void SendEmail(string message);
        void SendSms(string message);
    }
}