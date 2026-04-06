using System;

namespace Assignment5
{
    
    public class InvalidMarksException : Exception
    {
        public InvalidMarksException(string message) : base(message) { }
    }

    internal class Scholarship
    {
        public double Merit(int marks, double fees)
        {
            if (marks >= 70 && marks <= 80)
            {
                return fees * 0.20;
            }
            else if (marks > 80 && marks <= 90)
            {
                return fees * 0.30;
            }
            else if (marks > 90)
            {
                return fees * 0.50;
            }
            else
            {
                throw new InvalidMarksException("Marks not eligible for scholarship.");
            }
        }
    }

    // Test Program
    class Program
    {
        static void Main()
        {
            try
            {
                Scholarship s = new Scholarship();

                Console.Write("Enter Marks: ");
                int marks = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Fees: ");
                double fees = Convert.ToDouble(Console.ReadLine());

                double result = s.Merit(marks, fees);

                Console.WriteLine("Scholarship Amount: " + result);
            }
            catch (InvalidMarksException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}