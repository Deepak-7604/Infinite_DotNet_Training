using System;

namespace Assignment2
{
    internal class StringOperations
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.WriteLine("Length of the word: " + word.Length);

           
            char[] chars = word.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);

            Console.WriteLine("Reversed word: " + reversed);

           
            Console.Write("\nEnter first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter second word: ");
            string word2 = Console.ReadLine();

            if (word1.Equals(word2))
            {
                Console.WriteLine("Both words are the same.");
            }
            else
            {
                Console.WriteLine("Both words are different.");
            }
        }
    }
}