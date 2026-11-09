using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.L_Liskov_Substitution_Principle
{

    class Bird1
    {
        public virtual void Eat()
        {
            Console.WriteLine("Bird is eating");
        }
    }

    interface IFly1
    {
        void Fly();
    }

    class Sparrow1 : Bird1, IFly1
    {
        public void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }
    }

    class Ostrich1 : Bird1
    {
        public void Walk()
        {
            Console.WriteLine("Ostrich is walking");
        }
    }

    class Flying
    {
        static void Main()
        {
            Bird1 b1 = new Sparrow1();
            Bird1 b2 = new Ostrich1();

            b1.Eat();
            b2.Eat();

            IFly1 flyingBird = new Sparrow1();
            flyingBird.Fly();

            Ostrich1 o = new Ostrich1();
            o.Walk();
        }
    }
}
