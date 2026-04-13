using System;

namespace Assignment2
{
    internal class MarksAnalysis
    {
        static void Main(string[] args)
        {
            int[] marks = new int[10];
            int sum = 0;

            
            Console.WriteLine("Enter 10 marks:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Mark " + (i + 1) + ": ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                sum += marks[i];
            }

            
            int min = marks[0];
            int max = marks[0];

           
            foreach (int mark in marks)
            {
                if (mark < min)
                    min = mark;

                if (mark > max)
                    max = mark;
            }

         
            double average = (double)sum / marks.Length;

        
            int[] asc = (int[])marks.Clone();
            Array.Sort(asc);

            
            int[] desc = (int[])marks.Clone();
            Array.Sort(desc);
            Array.Reverse(desc);

           
            Console.WriteLine("\nTotal Marks: " + sum);
            Console.WriteLine("Average Marks: " + average);
            Console.WriteLine("Minimum Marks: " + min);
            Console.WriteLine("Maximum Marks: " + max);

            Console.WriteLine("\nMarks in Ascending Order:");
            Console.WriteLine(string.Join(" ", asc));

            Console.WriteLine("\nMarks in Descending Order:");
            Console.WriteLine(string.Join(" ", desc));
        }
    }
}