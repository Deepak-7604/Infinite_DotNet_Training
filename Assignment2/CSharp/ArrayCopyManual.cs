using System;

namespace Assignment2
{
    internal class ArrayCopy
    {
        static void Main(string[] args)
        {
            
            int[] source = { 5, 10, 15, 20, 25 };

          
            int[] destination = new int[source.Length];

        
            for (int i = 0; i < source.Length; i++)
            {
                destination[i] = source[i];
            }

            
            Console.WriteLine("Source Array:");
            for (int i = 0; i < source.Length; i++)
            {
                Console.Write(source[i] + " ");
            }

           
            Console.WriteLine("\nDestination Array:");
            for (int i = 0; i < destination.Length; i++)
            {
                Console.Write(destination[i] + " ");
            }
        }
    }
}