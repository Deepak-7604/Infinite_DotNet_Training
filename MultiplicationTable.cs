using System;

namespace Day1
{
    internal class SumTriple
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;

            if (a == b)
                sum = sum * 3;

            Console.WriteLine("Result: " + sum);
        }
    }
}