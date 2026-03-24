using System;

namespace Day1
{
    internal static class Calculator
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the first Number: ");
            string s1 = Console.ReadLine();
            Console.Write("Input operation: ");
            string op = Console.ReadLine();
            Console.Write("Input second number: ");
            string s2 = Console.ReadLine();

            double a, b;
            if (!double.TryParse(s1, out a) || !double.TryParse(s2, out b))
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
                return;
            }

            double add = a + b;
            double sub = a - b;
            double mul = a * b;

            Console.WriteLine("{0} + {1} = {2}", Format(a), Format(b), Format(add));
            Console.WriteLine("{0} - {1} = {2}", Format(a), Format(b), Format(sub));
            Console.WriteLine("{0} * {1} = {2}", Format(a), Format(b), Format(mul));

            if (Math.Abs(b) < double.Epsilon)
            {
                Console.WriteLine("{0} / {1} = Division by zero", Format(a), Format(b));
            }
            else
            {
                double div = a / b;
                Console.WriteLine("{0} / {1} = {2}", Format(a), Format(b), Format(div));
            }

           
            if (!string.IsNullOrEmpty(op))
            {
                switch (op.Trim())
                {
                    case "+":
                        Console.WriteLine("\nSelected: {0} + {1} = {2}", Format(a), Format(b), Format(add));
                        break;
                    case "-":
                        Console.WriteLine("\nSelected: {0} - {1} = {2}", Format(a), Format(b), Format(sub));
                        break;
                    case "*":
                    case "x":
                    case "X":
                        Console.WriteLine("\nSelected: {0} * {1} = {2}", Format(a), Format(b), Format(mul));
                        break;
                    case "/":
                        if (Math.Abs(b) < double.Epsilon)
                            Console.WriteLine("\nSelected: {0} / {1} = Division by zero", Format(a), Format(b));
                        else
                            Console.WriteLine("\nSelected: {0} / {1} = {2}", Format(a), Format(b), Format(a / b));
                        break;
                    default:
                        Console.WriteLine("\nUnknown operation '{0}'.", op);
                        break;
                }
            }
        }

        static string Format(double v)
        {
            
            if (Math.Abs(v - Math.Round(v)) < 1e-10)
                return ((long)Math.Round(v)).ToString();
            return v.ToString();
        }
    }
}
