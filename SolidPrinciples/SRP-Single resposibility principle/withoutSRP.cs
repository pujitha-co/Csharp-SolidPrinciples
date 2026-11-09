using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.SRP_Single_resposibility_principle
{


    class Student
    {
        public string Name;
        public int Mark1;
        public int Mark2;
        public int Mark3;

        public void GetDetails()
        {
            Console.WriteLine("Student Name: " + Name);
        }

        public void CalculateTotal()
        {
            int total = Mark1 + Mark2 + Mark3;

            Console.WriteLine("Total Marks: " + total);
        }

        public void GenerateReport()
        {
            Console.WriteLine("Student Report Generated");
        }
    }

    class Program
    {
        static void Main()
        {
            Student s = new Student();

            s.Name = "Pujitha";
            s.Mark1 = 85;
            s.Mark2 = 90;
            s.Mark3 = 95;

            s.GetDetails();
            s.CalculateTotal();
            s.GenerateReport();
        }
    }
}
