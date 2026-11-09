using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.O_Open_Closed_Principle
{

    abstract class Payment1
    {
        public abstract void Pay();
    }
    class UpiPayment : Payment1
    {
        public override void Pay()
        {
            Console.WriteLine("UPI Payment Successful");
        }
    }
    class CardPayment : Payment1
    {
        public override void Pay()
        {
            Console.WriteLine("Card Payment Successful");
        }
    }
    class CashPayment : Payment1
    {
        public override void Pay()
        {
            Console.WriteLine("Cash Payment Successful");
        }
    }
    class Pay
    {
        static void Main()
        {
            List<Payment1> payments = new List<Payment1>
            {
                new UpiPayment(),
                new CardPayment(),
                new CashPayment()
            };
            foreach (var payment in payments)
            {
                payment.Pay();
            }
        }
    }
}

