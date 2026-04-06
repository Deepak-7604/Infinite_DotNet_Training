using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment4
{
    class SortStackDescending
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            // Input
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter elements:");

            for (int i = 0; i < n; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                stack.Push(value);
            }

            // Sort stack in descending order
            Stack<int> sortedStack = SortStackDescending(stack);

            // Output
            Console.WriteLine("\nStack elements in descending order:");
            foreach (int item in sortedStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n------ Program Executed Successfully -------");
            Console.ReadKey();
        }

        static Stack<int> SortStackDescending(Stack<int> stack)
        {
            // Convert stack to list
            List<int> list = stack.ToList();

            // Sort in descending order
            list.Sort();
            list.Reverse();

            // Push back into new stack
            Stack<int> sorted = new Stack<int>();
            foreach (int item in list)
            {
                sorted.Push(item);
            }

            return sorted;
        }
    }
}