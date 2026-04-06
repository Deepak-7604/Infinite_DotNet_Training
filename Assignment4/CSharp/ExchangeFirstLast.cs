using System;

namespace Assignment4
{
    class ExchangeFirstLast
    {
        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            string newstr = SwapChar(str);

            // Output
            Console.WriteLine($"Original String: {str}");
            Console.WriteLine($"After exchanging first and last characters: {newstr}");

            Console.WriteLine("\n------Program Executed Successfully------");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static string SwapChar(string str)
        {
           
            if (string.IsNullOrEmpty(str) || str.Length == 1)
            {
                return str;
            }

            char firstChar = str[0];
            char lastChar = str[str.Length - 1];

            char[] charArray = str.ToCharArray();

           
            charArray[0] = lastChar;
            charArray[str.Length - 1] = firstChar;

            return new string(charArray);
        }
    }
}