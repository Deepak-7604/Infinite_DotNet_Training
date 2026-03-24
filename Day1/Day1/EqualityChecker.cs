using System;

namespace Day1
{
    internal static class EqualityChecker
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("Enter the first Number : ");
            string input1 = Console.ReadLine();
            Console.Write("Enter the second number : ");
            string input2 = Console.ReadLine();

            int num1, num2;
            if (!int.TryParse(input1, out num1) || !int.TryParse(input2, out num2))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if (num1 == num2)
            {
                Console.WriteLine("{0} and {1} are equal", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal", num1, num2);
            }
        }
    }
}
