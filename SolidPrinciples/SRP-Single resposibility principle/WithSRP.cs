using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.SRP_Single_resposibility_principle
{


    class Student1
    {
        public string Name;
        public int Mark1;
        public int Mark2;
        public int Mark3;

        public void GetDetails()
        {
            Console.WriteLine("Student Name: " + Name);
        }
    }

    class Result
    {
        public void CalculateTotal(Student s)
        {
            int total = s.Mark1 + s.Mark2 + s.Mark3;

            Console.WriteLine("Total Marks: " + total);
        }
    }

    class StudentReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Student Report Generated");
        }
    }

    class classroom
    {
        static void Main()
        {
            Student s = new Student();

            s.Name = "Pujitha";
            s.Mark1 = 85;
            s.Mark2 = 90;
            s.Mark3 = 95;

            Result r = new Result();

            StudentReport report = new StudentReport();

            s.GetDetails();
            r.CalculateTotal(s);
            report.GenerateReport();
        }
    }
}

