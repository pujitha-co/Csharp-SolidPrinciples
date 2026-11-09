using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.D_Dependency_Inversion_Principle
{

    class Email
    {
        public void Send()
        {
            Console.WriteLine("Email Sent Successfully");
        }
    }

    class Notification
    {
        Email email = new Email();

        public void SendNotification()
        {
            email.Send();
        }
    }

    class Program
    {
        static void Main()
        {
            Notification n = new Notification();

            n.SendNotification();
        }
    }
}
