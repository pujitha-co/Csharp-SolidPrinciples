using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.I_Interface_Segregation_Principle
{


    interface IPrinter
    {
        void Print();
        void Scan();
        void Copy();
    }

    class NormalPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing Document");
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }

        public void Copy()
        {
            throw new NotImplementedException();
        }
    }

    class AdvancedPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing Document");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning Document");
        }

        public void Copy()
        {
            Console.WriteLine("Copying Document");
        }
    }

    class Program
    {
        static void Main()
        {
            NormalPrinter p1 = new NormalPrinter();

            p1.Print();
            p1.Scan();
        }
    }
}
