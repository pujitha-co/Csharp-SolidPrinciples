using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.D_Dependency_Inversion_Principle
{
    interface IMessage
    {
        void Send();
    }

    class Email1 : IMessage
    {
        public void Send()
        {
            Console.WriteLine("Email Sent Successfully");
        }
    }

    class SMS : IMessage
    {
        public void Send()
        {
            Console.WriteLine("SMS Sent Successfully");
        }
    }

    class WhatsApp : IMessage
    {
        public void Send()
        {
            Console.WriteLine("WhatsApp Message Sent Successfully");
        }
    }

    class Notification1
    {
        private IMessage message;

        public Notification1(IMessage message)
        {
            this.message = message;
        }

        public void SendNotification()
        {
            message.Send();
        } 
    }

    class contact
    {
        static void Main()
        {
            Notification1 n1 =
                new Notification1(new Email1());

            Notification1 n2 =
                new Notification1(new SMS());

            Notification1 n3 =
                new Notification1(new WhatsApp());

            n1.SendNotification();
            n2.SendNotification();
            n3.SendNotification();
        }
    }
}
