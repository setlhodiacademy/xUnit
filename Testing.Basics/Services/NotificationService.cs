using System;
using System.Collections.Generic;
using System.Text;
using Testing.Basics.Services.Exceptions;

namespace Testing.Basics.Services
{
    public class NotificationService : INotificationService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine("===============Sending Email Started================");
            Console.WriteLine($"==============={message}================");
            Console.WriteLine("===============Sending Email Completed==============");
        }

        public void SendSms(string message)
        {
            Console.WriteLine("===============Sending SMS Started================");
            Console.WriteLine($"==============={message}================");
            Console.WriteLine("===============Sending SMS Completed==============");
        }

        public void NotifyAllChannels(string message)
        {
            throw new CommunicationChannelException("Email/SMS services are down.");
            //SendEmail(message);
            // SendSms(message);
        }
    }
}
