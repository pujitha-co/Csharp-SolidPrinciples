using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.I_Interface_Segregation_Principle
{
    interface IPrint
    {
        void Print();
    }

    interface IScan
    {
        void Scan();
    }

    interface ICopy
    {
        void Copy();
    }

    class NormalPrinter1 : IPrint
    {
        public void Print()
        {
            Console.WriteLine("Printing Document");
        }
    }

    class AdvancedPrinter1 : IPrint, IScan, ICopy
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

    class printer
    {
        static void Main()
        {
            NormalPrinter1 p1 = new NormalPrinter1();

            AdvancedPrinter1 p2 = new AdvancedPrinter1();

            p1.Print();

            p2.Print();
            p2.Scan();
            p2.Copy();
        }
    }
}
