using System;
using System.Collections.Generic;
using System.Text;
using Testing.Basics.Services;

namespace Testing.Basics.Tests
{
    public class NotificationServiceFake : INotificationService
    {
        public void NotifyAllChannels(string message)
        {
            // throw new NotImplementedException();
        }

        public void SendEmail(string message)
        {
            // throw new NotImplementedException();
        }

        public void SendSms(string message)
        {
            // throw new NotImplementedException();
        }
    }
}
