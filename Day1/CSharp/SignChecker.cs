using System;

namespace Day1
{
    internal static class SignChecker
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int n;
            if (!int.TryParse(input, out n))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if (n > 0)
            {
                Console.WriteLine("{0} is a positive number", n);
            }
            else if (n < 0)
            {
                Console.WriteLine("{0} is a negative number", n);
            }
            else
            {
                Console.WriteLine("{0} is zero", n);
            }
        }
    }
}
