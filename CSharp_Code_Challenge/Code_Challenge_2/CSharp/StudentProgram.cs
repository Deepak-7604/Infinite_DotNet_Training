using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_2
{
    
    abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }

        
        public abstract bool IsPassed(double grade);
    }

    // Undergraduate class
    class UndergraduateStudent : Student
    {
        public override bool IsPassed(double grade)
        {
            if (grade > 70)
                return true;
            else
                return false;
        }
    }

    // Graduate class
    class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            if (grade > 80)
                return true;
            else
                return false;
        }
    }

    class StudentProgram
    {
        static void Main(string[] args)
        {
            UndergraduateStudent ug = new UndergraduateStudent();
            ug.Name = "Deepak L";
            ug.StudentId = 611722;
            ug.Grade = 75.0;

            Graduate g = new Graduate();
            g.Name = "Deepak L";
            g.StudentId = 611722;
            g.Grade = 85.0;

            Console.WriteLine("Undergraduate Student Details:");
            Console.WriteLine("Name: " + ug.Name);
            Console.WriteLine("Student ID: " + ug.StudentId);
            Console.WriteLine("Grade: " + ug.Grade);
            Console.WriteLine("Is Passed: " + ug.IsPassed(ug.Grade));

            Console.WriteLine();

            Console.WriteLine("Graduate Student Details:");
            Console.WriteLine("Name: " + g.Name);
            Console.WriteLine("Student ID: " + g.StudentId);
            Console.WriteLine("Grade: " + g.Grade);
            Console.WriteLine("Is Passed: " + g.IsPassed(g.Grade));

            Console.WriteLine("\n------- Program Executed Successfully --------");
            Console.Read();
        }
    }
}