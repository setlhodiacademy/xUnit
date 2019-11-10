using System;
using System.Collections.Generic;
using System.Text;

namespace Testing.Basics.Services.Exceptions
{
    public class CommunicationChannelException : Exception
    {
        public CommunicationChannelException(string error) : base(error)
        {
        }
    }
}
