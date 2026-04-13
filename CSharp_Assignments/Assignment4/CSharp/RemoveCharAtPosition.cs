using System;

namespace Assignment4
{
    class Remove_Char
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();

            Console.WriteLine("\nEnter the position of character: ");
            int pos = Convert.ToInt32(Console.ReadLine());

           
            string resultstr = NewString(str, pos);

           
            Console.WriteLine($"\nAfter removing: {resultstr}");

            Console.WriteLine("\n-----------Program Executed Successfully---------");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static string NewString(string str, int index)
        {
            if (index < 0 || index >= str.Length)
            {
                Console.WriteLine("\nInvalid position! Returning original string.");
                return str;
            }

            return str.Remove(index, 1);
        }
    }
}