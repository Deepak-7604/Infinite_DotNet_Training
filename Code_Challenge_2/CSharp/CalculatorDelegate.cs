using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_2
{
    
    delegate int CalculatorDelegate(int a, int b);

    class Calculator
    {
        // Method for Addition
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Method for Subtraction
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        // Method for Multiplication
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== Calculator Using Delegate =====\n");

            // Input two integers
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            // Declare delegate object
            CalculatorDelegate calc;

            // Addition
            calc = Add;
            int sum = calc(num1, num2);
            Console.WriteLine($"\nAddition of {num1} and {num2} = {sum}");

            // Subtraction
            calc = Subtract;
            int difference = calc(num1, num2);
            Console.WriteLine($"Subtraction of {num1} and {num2} = {difference}");

            // Multiplication
            calc = Multiply;
            int product = calc(num1, num2);
            Console.WriteLine($"Multiplication of {num1} and {num2} = {product}");

            Console.WriteLine("\nProgram executed successfully. Press any key to exit.");
            Console.Read();
        }
    }
}