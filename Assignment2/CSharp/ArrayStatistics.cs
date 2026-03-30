using System;

namespace Assignment2
{
    internal class ArrayOperations
    {
        static void Main(string[] args)
        {
            
            int[] numbers = { 10, 20, 30, 40, 50 };

            int sum = 0;
            int min = numbers[0];
            int max = numbers[0];

           
            foreach (int num in numbers)
            {
                sum += num;

                if (num < min)
                    min = num;

                if (num > max)
                    max = num;
            }

            double average = (double)sum / numbers.Length;

         
            Console.WriteLine("Array elements: " + string.Join(", ", numbers));
            Console.WriteLine("Average value: " + average);
            Console.WriteLine("Minimum value: " + min);
            Console.WriteLine("Maximum value: " + max);
        }
    }
}