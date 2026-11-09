using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.O_Open_Closed_Principle
{
    class Payment
    {
        public void Pay(string type)
        {
            if (type == "UPI")
            {
                Console.WriteLine("UPI Payment Successful");
            }
            else if (type == "Card")
            {
                Console.WriteLine("Card Payment Successful");
            }
            else if (type == "Cash")
            {
                Console.WriteLine("Cash Payment Successful");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Payment p = new Payment();

            p.Pay("UPI");
            p.Pay("Card");
            p.Pay("Cash");
        }
    }
}
