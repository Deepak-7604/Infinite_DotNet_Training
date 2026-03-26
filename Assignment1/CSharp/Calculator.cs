using System;

namespace Day1
{
    internal class Calculator
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            if (op == '+')
                result = a + b;
            else if (op == '-')
                result = a - b;
            else if (op == '*')
                result = a * b;
            else if (op == '/')
            {
                if (b != 0)
                    result = a / b;
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid operator");
                return;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}