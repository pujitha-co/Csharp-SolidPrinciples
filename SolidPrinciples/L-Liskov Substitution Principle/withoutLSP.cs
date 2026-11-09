using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.L_Liskov_Substitution_Principle
{

    class Bird
    {
        public virtual void Eat()
        {
            Console.WriteLine("Bird is eating");
        }

        public virtual void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }

    class Sparrow : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }
    }

    class Ostrich : Bird
    {
        public override void Fly()
        {
            throw new NotImplementedException(
                "Ostrich cannot fly");
        }
    }

    class Program
    {
        static void Main()
        {
            Bird b1 = new Sparrow();
            Bird b2 = new Ostrich();

            b1.Fly();
            b2.Fly();
        }
    }
}
